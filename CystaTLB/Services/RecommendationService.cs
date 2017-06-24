using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace CystaTLB.Services
{
    public class RecommendationService
    {

        public static async Task<Models.RecommendationItem.GoodreadsResponse> GetRecommendationInfo(string title)
        {
            string uri = $"https://www.goodreads.com/book/title.xml?key=Qxl99kz8vdbIh9Z6mCqo3w&title={title}";
            var bookItem = new Models.RecommendationItem.GoodreadsResponse();

            using (var client = new WebClient())
            {
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;

                XmlSerializer serializer = new XmlSerializer(typeof(Models.RecommendationItem.GoodreadsResponse));


                WebResponse response = request.GetResponse();
                bookItem = (Models.RecommendationItem.GoodreadsResponse)serializer.Deserialize(response.GetResponseStream());
                bookItem.book.title = bookItem.book.title ?? "FAIL";

            }
            return bookItem;


        }

        public static async Task<Models.RecommendationItem.GoodreadsResponse> GetBookDesc1(string title, string author)
        {
            string uri = $"https://www.goodreads.com/book/title.xml?author={author}&key=Qxl99kz8vdbIh9Z6mCqo3w&title={title}";
            var bookItem = new Models.RecommendationItem.GoodreadsResponse();
            using (var client = new WebClient())
            {
                //var rawData = await client.DownloadStringTaskAsync(new Uri(uri));
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                XmlSerializer serializer = new XmlSerializer(typeof(Models.RecommendationItem.GoodreadsResponse));
                //StreamReader reader = new StreamReader(rawData.GetResponseStream());
                WebResponse response = request.GetResponse();
                bookItem = (Models.RecommendationItem.GoodreadsResponse)serializer.Deserialize(response.GetResponseStream());
                bookItem.book.title = bookItem.book.title ?? "FAIL";

            }
            return bookItem;


        }

    }
}