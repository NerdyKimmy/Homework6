using System.Text.Json.Serialization;

public class Book
{
    [JsonIgnore]  
    public int PublishingHouseId { get; set; }
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
    public Dictionary<string, object> ToSerializedObject()
    {
        return new Dictionary<string, object>
        {
            { "Name", this.Title },
            { "PublishingHouse", this.PublishingHouse }
        };
    }
}
