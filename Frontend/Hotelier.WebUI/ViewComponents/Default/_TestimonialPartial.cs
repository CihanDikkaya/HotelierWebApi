using Hotelier.WebUI.DTOS.ServiceDTO;
using Hotelier.WebUI.DTOS.TestimonialDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:61440/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsdata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDTO>>(jsdata);
                return View(values);
            }
            return View();
        }
    }
}
