using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kanye_Rest.Pages
{
    public class ResponseModel : PageModel
    {
        public string ResponseBody { get; set; }

        public void OnGet(string result)
        {
            result = result.Replace("{\"quote\":", "").Replace("}", "");
            ResponseBody = result;
        }
    }
}
