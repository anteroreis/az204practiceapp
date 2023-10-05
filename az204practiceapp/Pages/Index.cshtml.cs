using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az204practiceapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var remoteHost = this.HttpContext.GetServerVariable("REMOTE_HOST");
            var remoteAddress = this.HttpContext.GetServerVariable("REMOTE_ADDR");
            var msg = $"OnGet remote host {remoteHost} remote address {remoteAddress}";

            _logger.LogInformation(msg);
        }

        public void OnPost()
        {

            var remoteHost = this.HttpContext.GetServerVariable("REMOTE_HOST");
            var remoteAddress = this.HttpContext.GetServerVariable("REMOTE_ADDR");
            var msg = $"OnPost remote host {remoteHost} remote address {remoteAddress}";

            _logger.LogInformation(msg);

            try
            {
                throw new NotImplementedException("OnPost not implemented yet!");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new NotImplementedException("OnPost not implemented yet!");
            }
        }
    }
}