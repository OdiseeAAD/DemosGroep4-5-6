using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Models
{
    public class Vak
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public List<Student> Studenten { get; set; }
    }
}
