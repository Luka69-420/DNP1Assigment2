using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models {
public class Interest
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public IList<Child> Children { get; set; }

    public Interest()
    {
        Children = new List<Child>();
    }

}
}