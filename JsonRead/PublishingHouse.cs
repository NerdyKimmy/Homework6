using System.Text.Json.Serialization;

public class PublishingHouse
{
    public int Id { get; set; }
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    [JsonPropertyName("Adress")]
    public string Address { get; set; }
}
