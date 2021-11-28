using System.ComponentModel.DataAnnotations;

namespace Models {
public class Pet {
    [Key]
    public int PetId { get; set; }
    
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
}