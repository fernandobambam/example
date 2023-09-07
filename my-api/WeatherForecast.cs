namespace MyApi;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public int Something { get; set; }

    public string Something2 { get; set; }

    public string Something3 { get; set; }

    public string Something4 { get; set; }
}
