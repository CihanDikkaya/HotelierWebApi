using Hotelier.WebUI.DTOS.BookingDTO;
using Hotelier.WebUI.DTOS.SubscribeDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDTO createBookingDTO)
        {
            createBookingDTO.Status = "Onay Bekliyor.";
            var client = _httpClientFactory.CreateClient();
            var jsdata = JsonConvert.SerializeObject(createBookingDTO);
            StringContent stringContent = new StringContent(jsdata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:61440/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
