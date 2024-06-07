using Hotelier.WebUI.DTOS.GuestDTO;
using Hotelier.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.WebUI.Controllers
{
    public class GuestController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GuestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:61440/api/Guest");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsdata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGuestDTO>>(jsdata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddGuest()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(CreateGuestDTO model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsdata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsdata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:61440/api/Guest", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:61440/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:61440/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsdata = await responseMessage.Content.ReadAsStringAsync();
                var val = JsonConvert.DeserializeObject<UpdateGuestDTO>(jsdata);
                return View(val);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDTO model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsdata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsdata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:61440/api/Guest/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
