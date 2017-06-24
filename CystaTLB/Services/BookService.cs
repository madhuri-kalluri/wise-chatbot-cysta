using CystaTLB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace CystaTLB.Services
{
    public class BookService
    {
        public static async Task<BookItem> GetBookInfo(string title)
        {
            string uri = $"https://www.googleapis.com/books/v1/volumes?q={title}";
            var bookItem = new BookItem();
            using (var client = new WebClient())
            {
                var rawData = await client.DownloadStringTaskAsync(new Uri(uri));
                bookItem = JsonConvert.DeserializeObject<BookItem>(rawData);
                bookItem.items[0].volumeInfo.title = bookItem.items[0].volumeInfo.title ?? "FAIL";
            }
            return bookItem;


        }

        public static async Task<BookItem> GetBookInfo1(string title, string author)
        {
            string uri = $"https://www.googleapis.com/books/v1/volumes?q={title}+inauthor:{author}";
            var bookItem = new BookItem();
            using (var client = new WebClient())
            {
                var rawData = await client.DownloadStringTaskAsync(new Uri(uri));
                bookItem = JsonConvert.DeserializeObject<BookItem>(rawData);
                bookItem.items[0].volumeInfo.title = bookItem.items[0].volumeInfo.title ?? "FAIL";
            }
            return bookItem;

        }

    }
}
