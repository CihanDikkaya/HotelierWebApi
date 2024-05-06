using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace RapidApiConsume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {
            if (!string.IsNullOrEmpty(cityID))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?locale=fr&filter_by_currency=EUR&checkin_date=2024-09-14&dest_type=city&dest_id={cityID}&adults_number=2&checkout_date=2024-09-15&order_by=popularity&room_number=1&units=metric&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true&page_number=0"),
                    Headers =
    {
        { "X-RapidAPI-Key", "5df7a1357bmshdf1e68bab15f06ap126866jsnc75d2030d2fa" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var val = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(val.results.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?locale=fr&filter_by_currency=EUR&checkin_date=2024-09-14&dest_type=city&dest_id=-1456928&adults_number=2&checkout_date=2024-09-15&order_by=popularity&room_number=1&units=metric&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true&page_number=0"),
                    Headers =
    {
        { "X-RapidAPI-Key", "5df7a1357bmshdf1e68bab15f06ap126866jsnc75d2030d2fa" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var val = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(val.results.ToList());
                }
            }
        }
    }
}
