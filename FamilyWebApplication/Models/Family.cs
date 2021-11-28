using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Family {
    [Key]
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    [Range (0 , 2)]
    public ICollection<Adult> Adults { get; set; }
    [Range (0 , 7)]
    public ICollection<Child> Children{ get; set; }
    public ICollection<Pet> Pets{ get; set; }
    
}


}