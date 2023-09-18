using Microsoft.Bot.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace LineBot
{
    [Route("api/line")]
    public class LineBotController : ControllerBase
    {
        private readonly IBotFrameworkHttpAdapter _adapter;
        private readonly IBot _bot;

        public LineBotController(IBotFrameworkHttpAdapter adapter, IBot bot)
        {
            _adapter = adapter;
            _bot = bot;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            // 處理Line的請求
            var response = new MessagingResponse();
            await _adapter.ProcessAsync(Request, Response, _bot);
            return Ok(response);
        }
    }
}

/*https://localhost:7113*/
/*http://localhost:5145*/

