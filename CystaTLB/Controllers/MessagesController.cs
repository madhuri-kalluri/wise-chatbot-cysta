using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder.Dialogs;
using CystaTLB.Services;

namespace CystaTLB
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                try
                {
                    await Conversation.SendAsync(activity, () => new CystaLuisDialog());
                }
                catch(System.InvalidOperationException e)
                {
                    Activity reply1 = activity.CreateReply("Hmmm, That is one book that I have yet to read. Let me get back to you on that. Why don't you ask for a different book in the mean time? " + e);
                    await connector.Conversations.ReplyToActivityAsync(reply1);
                }
                catch(Exception e)
                {
                    Random rnd = new Random();
                    string []message = { "Sorry this is something which my inferior neural network cannot understand \n\n\n","Hmmm, My assistant is a little slow, can you please rephrase that?"};
                    Activity reply1 = activity.CreateReply(message[rnd.Next(0,1)]+e);
                    await connector.Conversations.ReplyToActivityAsync(reply1);
                }
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}