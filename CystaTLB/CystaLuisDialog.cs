using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System.Threading.Tasks;
using CystaTLB.Services;

namespace CystaTLB
{

    [Serializable]
#if useSampleModel
    [LuisModel("cd2c6f0e-086d-4ae7-a35c-ed7f1cf84c4c", "eb7529ef4b8f4b85a8397daef4dc1e90")]
#else
    [LuisModel("cd2c6f0e-086d-4ae7-a35c-ed7f1cf84c4c", "eb7529ef4b8f4b85a8397daef4dc1e90")]
#endif
    public class CystaLuisDialog : LuisDialog<object>
    {
                
            public object Url { get; private set; }

        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = $"Sorry!! I didn't get your Message '{result.Query}'. Type 'help' if you need assistance.";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
        [LuisIntent("SearchBook")]
        public async Task SearchBook(IDialogContext context, LuisResult result)
        {
            
            var entitiesArray = result.Entities;
            //  int k = 0;
            var resultMessage = context.MakeMessage();
            if (result.Query.StartsWith("Getting the details of "))
            {
                string activity = result.Query;

                string titl = "", auth = "";
                int lenby = activity.IndexOf("By "), lenend = activity.Length;
                titl = activity.Substring(22, lenby - 22);
                auth = activity.Substring((lenby + 3), (lenend - lenby - 3));
                var GRser1 = await BookService.GetBookInfo1(titl, auth);
                resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                resultMessage.Attachments = new List<Attachment>();
                string desc = ((GRser1.items[0].volumeInfo.description.Length < 300) ? GRser1.items[0].volumeInfo.description : (GRser1.items[0].volumeInfo.description.Substring(0, 300) + "..."));
                ThumbnailCard plCard1 = new ThumbnailCard()
                {

                    Title = GRser1.items[0].volumeInfo.title,
                    Subtitle = $"Author: \n{GRser1.items[0].volumeInfo.authors[0]} \n\nRating: \n{GRser1.items[0].volumeInfo.averageRating} \n\nDescription:  {desc}",
                    Images = new List<CardImage>()
                            {
                            new CardImage() { Url =  GRser1.items[0].volumeInfo.imageLinks.thumbnail,
                            }
                        },
                    Buttons = new List<CardAction>()
                        {
                            new CardAction()
                            {
                                Title = "Preview Link",
                                Type = ActionTypes.OpenUrl,
                                Value = GRser1.items[0].volumeInfo.previewLink,
                            },
                            new CardAction()
                            {
                                Title="Buy Book",
                                Type = ActionTypes.OpenUrl,
                                Value = GRser1.items[0].saleInfo.buyLink,
                            }
                        }

                };
                Attachment plAttachment1 = plCard1.ToAttachment();
                resultMessage.Attachments.Add(plAttachment1);
                await context.PostAsync(resultMessage);


            }
            else
            {
                foreach (var entityItem in result.Entities)
                {
                    if (entityItem.Type == "bookTitle")
                    {
                        int i = 0;
                        var GRser = await BookService.GetBookInfo(entityItem.Entity);
                        resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                        resultMessage.Attachments = new List<Attachment>();

                        foreach (var item in GRser.items)
                        {
                            HeroCard plCard = new HeroCard()
                            {
                                Title = item.volumeInfo.title,
                                Subtitle = item.volumeInfo.authors[0],
                                Images = new List<CardImage>()
                            {new CardImage() { Url =  item.volumeInfo.imageLinks.thumbnail},

                        },
                                Buttons = new List<CardAction>()
                        {
                            new CardAction()
                            {
                                Title = "More details",
                                Type = ActionTypes.ImBack,
                                Value = "Getting the details of " + item.volumeInfo.title+" By "+ item.volumeInfo.authors[0]

                            }
                        }

                            };
                            Attachment plAttachment = plCard.ToAttachment();
                            resultMessage.Attachments.Add(plAttachment);
                            i++;
                            if (i >= 9) break;
                        }

                        await context.PostAsync(resultMessage);
                    }
                }

            }
            context.Wait(this.MessageReceived);
        }
        [LuisIntent("GreetMsg")]
        public async Task GM(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Hi I am Cysta!! I hear that you are looking for new books to read. Why don't you name a book that you have read?\n" + "\nTry asking me things like 'find me the book matilda' or 'recommend me books by Dan Brown' or 'recommend me books based on The Alchemist' ");
            context.Wait(this.MessageReceived);
        }


        [LuisIntent("recommendBook")]
        public async Task RB(IDialogContext context, LuisResult result)
        {

            var entitiesArray = result.Entities;
            //    int k = 0;
            var resultMessage = context.MakeMessage();
            if (result.Query.StartsWith("Getting details of "))
            {
                string activity = result.Query;

                string titl = "", auth = "";
                int lenby = activity.IndexOf("By "), lenend = activity.Length;
                titl = activity.Substring(22, lenby - 22);
                auth = activity.Substring((lenby + 3), (lenend - lenby - 3));
                var GRser1 = await BookService.GetBookInfo1(titl, auth);


                resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                resultMessage.Attachments = new List<Attachment>();
                string desc = ((GRser1.items[0].volumeInfo.description.Length < 300) ? GRser1.items[0].volumeInfo.description : (GRser1.items[0].volumeInfo.description.Substring(0, 300) + "..."));
                ThumbnailCard plCard1 = new ThumbnailCard()
                {

                    Title = GRser1.items[0].volumeInfo.title,
                    Subtitle = $"Author: \n{GRser1.items[0].volumeInfo.authors[0]} \n\nRating: \n{GRser1.items[0].volumeInfo.averageRating} \n\nDescription:  {desc}",
                    Images = new List<CardImage>()
                            {
                            new CardImage() { Url =  GRser1.items[0].volumeInfo.imageLinks.thumbnail,
                            }
                        },
                    Buttons = new List<CardAction>()
                    {
                        new CardAction()
                        {
                            Title = "Preview Link",
                            Type = ActionTypes.OpenUrl,
                            Value = GRser1.items[0].volumeInfo.previewLink,
                        },
                        new CardAction()
                        {
                            Title="Buy Book",
                            Type = ActionTypes.OpenUrl,
                            Value = GRser1.items[0].saleInfo.buyLink,
                        }
                    }

                };
                Attachment plAttachment1 = plCard1.ToAttachment();
                resultMessage.Attachments.Add(plAttachment1);
                await context.PostAsync(resultMessage);

            }
            else
            {
                foreach (var entityItem in result.Entities)
                {
                    if (entityItem.Type == "bookTitle")
                    {
                        int i = 0;
                        var GRser = await RecommendationService.GetRecommendationInfo(entityItem.Entity);
                        resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                        resultMessage.Attachments = new List<Attachment>();

                        foreach (var item in GRser.book.similar_books)
                        {
                            HeroCard plCard = new HeroCard()
                            {
                                Title = item.title,
                                Subtitle = item.authors.author.name,
                                Images = new List<CardImage>()
                            {new CardImage() { Url =  item.image_url},

                        },
                                Buttons = new List<CardAction>()
                        {
                            new CardAction()
                            {
                                Title = "More details",
                                Type = ActionTypes.ImBack,
                                Value = "Getting the details of " + item.title+" By "+ item.authors.author.name

                            }
                        }

                            };
                            Attachment plAttachment = plCard.ToAttachment();
                            resultMessage.Attachments.Add(plAttachment);
                            i++;

                        }

                        await context.PostAsync(resultMessage);
                    }

                    if (entityItem.Type == "author")
                    {
                        int i = 0;
                        var GRser = await AuthorService.GetAuthorInfo(entityItem.Entity);
                        resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                        resultMessage.Attachments = new List<Attachment>();

                        foreach (var item in GRser.search.results)
                        {
                            HeroCard plCard = new HeroCard()
                            {
                                Title = item.best_book.title,
                                Subtitle = item.best_book.author.name,
                                Images = new List<CardImage>()
                                {new CardImage() { Url =  item.best_book.image_url},

                            },
                                Buttons = new List<CardAction>()
                            {
                                new CardAction()
                                {
                                    Title = "Get details",
                                    Type = ActionTypes.ImBack,
                                    Value = "Getting the details of " + item.best_book.title + " By " + item.best_book.author.name

                                }
                            }

                            };
                            Attachment plAttachment = plCard.ToAttachment();
                            resultMessage.Attachments.Add(plAttachment);
                            i++;

                        }

                        await context.PostAsync(resultMessage);
                    }

                    if (entityItem.Type == "genre")
                    {
                        int i = 0;
                        var GRser = await GenreService.GetGenreInfo(entityItem.Entity);
                        resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                        resultMessage.Attachments = new List<Attachment>();
                        var GRser1 = await BookService.GetBookInfo(entityItem.Entity);

                        foreach (var item in GRser.book)
                        {
                            HeroCard plCard = new HeroCard()
                            {
                                Title = item.title,
                                Subtitle = item.author,
                                Buttons = new List<CardAction>()
                                {
                                    new CardAction()
                                    {
                                        Title = "Get Details",
                                        Type = ActionTypes.ImBack,
                                        Value = "Getting the details of "+ item.title + " By "+ item.author

                                    }
                                }

                            };
                            Attachment plAttachment = plCard.ToAttachment();
                            resultMessage.Attachments.Add(plAttachment);
                            i++;

                        }

                        await context.PostAsync(resultMessage);
                    }




                }

            }
            context.Wait(this.MessageReceived);
        }

        private async void createCard(IDialogContext context, string titl, string auth)
        {
            var resultMessage = context.MakeMessage();
            var GRser1 = await RecommendationService.GetBookDesc1(titl, auth);
            resultMessage.AttachmentLayout = AttachmentLayoutTypes.Carousel;
            resultMessage.Attachments = new List<Attachment>();
            string desc = ((GRser1.book.description.Length < 300) ? GRser1.book.description : (GRser1.book.description.Substring(0, 300) + "..."));


            ThumbnailCard plCard1 = new ThumbnailCard()
            {

                Title = GRser1.book.title,
                Subtitle = $"Author: \n{GRser1.book.authors.author.name}| \n\nRating: \n{GRser1.book.average_rating} \n\nDescription:  {desc}",
                Images = new List<CardImage>()
                            {
                            new CardImage() { Url =  GRser1.book.image_url,
                            }
                        },
                Buttons = new List<CardAction>()
                        {
                            new CardAction()
                            {
                                Title = "Goodreads Link",
                                Type = ActionTypes.OpenUrl,
                                Value = GRser1.book.link,
                            },
                            new CardAction()
                            {
                                Title="Buy Book",
                                Type = ActionTypes.OpenUrl,
                                Value = GRser1.book.buy_links[0].link,
                            }
                        }

            };
            Attachment plAttachment1 = plCard1.ToAttachment();
            resultMessage.Attachments.Add(plAttachment1);
            await context.PostAsync(resultMessage);

        }

    
        }
    }

