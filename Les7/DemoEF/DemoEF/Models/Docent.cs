using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Models
{
    [Table("tblDocent")]
    public class Docent: Persoon
    {
        public Docent(string voornaam, string achternaam, DateTime geboorteDatum, string specialisatie) : base(voornaam, achternaam, geboorteDatum)
        {
            Specialisatie = specialisatie;
        }

        public string Specialisatie { get; set; }
    }
}
