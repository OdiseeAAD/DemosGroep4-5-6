using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF.Models
{
    [Table("tblPersonen")]
    public class Persoon
    {
        public int Id { get; set; }
        [Column("voornaam")]
        [Required]
        public string Voornaam { get; set; }

        [Column("achternaam")]
        [Required]
        [MaxLength(50)]
        public string Achternaam { get; set; }

        [Column(TypeName ="datetime2")]
        [Required]
        public DateTime GeboorteDatum { get; set; }

        public Woonplaats? Woonplaats { get; set; }

        public Persoon()
        {
            
        }

        public Persoon(string voornaam, string achternaam, DateTime geboorteDatum)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            GeboorteDatum = geboorteDatum;
        }
    }
}
