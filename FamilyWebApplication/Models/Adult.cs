using System.ComponentModel.DataAnnotations;

namespace Models {
public class Adult : Person
{
    public int Id{ get; set; }
    public Job Job { get; set; }

    public Adult()
    {
        Job = new Job();
    }
}
}