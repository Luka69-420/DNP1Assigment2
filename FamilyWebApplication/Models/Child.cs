using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Child : Person
{
    public int Id{ get; set; }
    public List<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }
}
}   