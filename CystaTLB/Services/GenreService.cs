using CystaTLB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace CystaTLB.Services
{
    public class GenreService
    {
        public static async Task<GenreItem.books> GetGenreInfo(string genre)
        {
            string uri = $"https://idreambooks.com/api/publications/recent_recos.xml?key=1bebbc6dc01543c27b117385f0718f28f3de687d&slug={genre}";
            var genreItem = new GenreItem.books();
            using (var client = new WebClient())
            {
                    HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;

                    XmlSerializer serializer = new XmlSerializer(typeof(Models.GenreItem.books));


                    WebResponse response = request.GetResponse();
                    genreItem = (Models.GenreItem.books)serializer.Deserialize(response.GetResponseStream());
                    genreItem.book[0].author = genreItem.book[0].author ?? "FAIL";
            }
            return genreItem;


        }


    }
}