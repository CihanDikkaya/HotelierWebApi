using Hotelier.BusinessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessage;

        public SendMessageController(ISendMessageService messageService)
        {
            _sendMessage = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var v = _sendMessage.TGetList();
            return Ok(v);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage message)
        {
            _sendMessage.TInsert(message);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var v = _sendMessage.TGetByID(id);
            _sendMessage.TDelete(v);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessage(SendMessage message)
        {
            _sendMessage.TUpdate(message);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var v = _sendMessage.TGetByID(id);
            return Ok(v);
        }
    }
}
