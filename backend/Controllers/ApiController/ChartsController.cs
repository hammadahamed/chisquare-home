using chi2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ChartsController : ControllerBase
{

     private readonly AppDbContext _dbContext;

    public ChartsController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        string type = HttpContext.Request.Query["type"];
        var charts = await _dbContext.Charts
            .Where(data => data.Type == type)
            .ToListAsync();
        var json = System.Text.Json.JsonSerializer.Serialize(charts);
        return Ok(json);
    }

    [HttpPost]
    public IActionResult Post([FromBody] ErrorViewModel model)
    {
        // Implementation for handling POST requests
        // You can use model binding to bind the incoming JSON data to a model
        return Ok("Successfully received a POST request.");
    }

    // Other actions for handling different HTTP methods and routes...
}
