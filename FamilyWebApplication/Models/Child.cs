using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Child : Person
{
    
    public int ChildId { get; set; }
    public ICollection<Interest> Interests { get; set; }
    public ICollection<Pet> Pets { get; set; }
}
}   