using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Adult : Person
    {
        
        public int AdultId { get; set; }
        public Job Job { get; set; }
    }
}