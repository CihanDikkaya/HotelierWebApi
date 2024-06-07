using Hotelier.WebUI.DTOS.RoomDTO;
using Hotelier.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:61440/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsdata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDTO>>(jsdata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDTO model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsdata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsdata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:61440/api/Room", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:61440/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:61440/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsdata = await responseMessage.Content.ReadAsStringAsync();
                var val = JsonConvert.DeserializeObject<UpdateRoomDTO>(jsdata);
                return View(val);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDTO model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsdata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsdata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:61440/api/Room/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
