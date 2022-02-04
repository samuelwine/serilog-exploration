using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace serilog_exploration.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var activity = Activity.Current;
        var myVar = 333;
        _logger.LogError("what is going on {addin here}??", myVar);
        _logger.LogInformation("Process starting now");
        _logger.LogCritical("Critical something happening!!");
    }
}
