using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using static CystaTLB.Models.AuthorItem;

namespace CystaTLB.Services
{
    public class AuthorService
    {
        public static async Task<GoodreadsResponse2> GetAuthorInfo(string author)
        {

            string uri = $"https://www.goodreads.com/search.xml?key=uQuCCD5GPNdmfPp7bdXroA&q={author}";
            var authorItem = new GoodreadsResponse2();

            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            XmlSerializer s = new XmlSerializer(typeof(GoodreadsResponse2), new XmlRootAttribute("GoodreadsResponse"));
            WebResponse response = request.GetResponse();
            using (var reader = new StringReader(uri))
            {
                authorItem = (GoodreadsResponse2)s.Deserialize(response.GetResponseStream());

            }

            authorItem.search.query = authorItem.search.query ?? "FAIL";

            return authorItem;


        }

    }
}