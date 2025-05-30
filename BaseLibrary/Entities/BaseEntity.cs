using System.Text.Json.Serialization;



namespace BaseLibrary.Entities;



/// <summary>
/// Defines the base entity.
/// </summary>
public class BaseEntity
{

    public int Id { get; set; }
    
    public string? Name { get; set; }

    [JsonIgnore]
    public List<Employee>? employees { get; set; }

}