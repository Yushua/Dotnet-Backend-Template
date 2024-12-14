using Microsoft.AspNetCore.Mvc;
namespace DotNetAPITemplate.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly string[] _summaries = new[] 
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly string[] _daysOfWeek = new[] 
    {
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    };

    [HttpGet("Week", Name = "GetWeekWeatherForecast")]
    public IEnumerable<WeatherForecast> GetFiveDayForecast()
    {
        var forecast = Enumerable.Range(1, 7).Select(index => 
            new WeatherForecast(
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                _summaries[Random.Shared.Next(_summaries.Length)],
                _daysOfWeek[(int)DateTime.Now.AddDays(index).DayOfWeek] 
            ))
        .ToArray();
        return forecast;
    }

    [HttpGet("Day", Name = "GetSingleDayForecast")]
    public ActionResult<WeatherForecast> GetSingleDayForecast(int dayIndex)
    {
        if (dayIndex < 1 || dayIndex > 7)
        {
            return BadRequest("Invalid day index. Please provide a day index between 1 and 7.");
        }

        var forecast = new WeatherForecast(
            DateOnly.FromDateTime(DateTime.Now.AddDays(dayIndex)),
            Random.Shared.Next(-20, 55),
            _summaries[Random.Shared.Next(_summaries.Length)],
            _daysOfWeek[(int)DateTime.Now.AddDays(dayIndex).DayOfWeek] 
        );

        return Ok(forecast);
    }

    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary, string DayOfWeek)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
