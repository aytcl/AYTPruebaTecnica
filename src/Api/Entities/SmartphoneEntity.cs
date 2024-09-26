using System.Text.Json.Serialization;

namespace PruebaTecnica.Entities;
public class SmartphoneEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Featured? Data { get; set; }
}

public class Featured
{
    public string? Color { get; set; }
    public string? Capacity { get; set; }
    public double? Price { get; set; }
    public string? Generation { get; set; }
    [JsonPropertyName("Screen size")]
    public double? ScreenSize { get; set; }
    public string? Description { get; set; }
}