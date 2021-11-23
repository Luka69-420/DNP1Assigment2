using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Models {
public class Person {
   
    public int Id { get; set; }
    [Required]
    [FromQuery]
    [JsonPropertyName("adultId")]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }
    public int Height { get; set; }
    public string Sex { get; set; }
}


}