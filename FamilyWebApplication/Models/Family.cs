using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Family {
    
    //public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    [Range (0 , 2)]
    public List<Adult> Adults { get; set; }
    [Range (0 , 7)]
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();     
    }
}


}