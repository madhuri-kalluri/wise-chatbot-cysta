using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using static CystaTLB.Models.GRBookItem;

namespace CystaTLB.Services
{
    public class GRSearchServices
    {
        public class GRSearchService
        {
            public static async Task<GoodreadsResponse> GetBookInfo(string title)
            {

                string uri = $"https://www.goodreads.com/search.xml?key=uQuCCD5GPNdmfPp7bdXroA&q={title}";
                var GoodreadsResponse = new GoodreadsResponse();

                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                XmlSerializer s = new XmlSerializer(typeof(GoodreadsResponse), new XmlRootAttribute("GoodreadsResponse"));
                WebResponse response = request.GetResponse();
                using (var reader = new StringReader(uri))
                {
                    GoodreadsResponse = (GoodreadsResponse)s.Deserialize(response.GetResponseStream());

                }

                GoodreadsResponse.search.results[0].best_book.title = GoodreadsResponse.search.results[0].best_book.title ?? "FAIL";

                return GoodreadsResponse;


            }
        }
    }
}