using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Models
{
    [Table("tblStudent")]
    public class Student: Persoon
    {
        public  string Opleiding { get; set; }
        public List<Vak> Vakken { get; set; }

        public Student(string voornaam, string achternaam, DateTime geboorteDatum, string opleiding):base(voornaam, achternaam, geboorteDatum)
        {
            Opleiding = opleiding;
        }
    }
}
