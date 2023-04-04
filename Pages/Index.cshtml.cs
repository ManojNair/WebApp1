using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpContextAccessor _contextAccessor;
    public string IPAddress { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor contextAccessor)
    {
        _logger = logger;
        _contextAccessor = contextAccessor;
    }

    public void OnGet()
    {
       IPAddress=  _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
        
    }
}