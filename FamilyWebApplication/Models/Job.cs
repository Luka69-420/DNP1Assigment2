using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        public int Id{ get; set; }
        
        public string Title { get; set; }
        public int Salary { get; set; }
    }
}