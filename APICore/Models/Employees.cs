using System.ComponentModel.DataAnnotations;

namespace APICore.Models
{
    public class Employees
    {
        [Key]
        public int eid { get; set; }
       public string ename { get; set; }
        public string email { get; set; }
        public string  department { get; set; }
        public string date { get; set; }
    }
}
