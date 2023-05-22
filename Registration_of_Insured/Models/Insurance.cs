using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Registration_of_Insured.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        [Display(Name = "Druh pojištění")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string KindOfInsurance { get; set; } = "";
        [Display(Name = "Pojistné plnění")]
        public int ClaimSettlement { get; set; }
        [Display(Name = "Předmět pojištění")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string ObjectOfInsurance { get; set; } = "";
        [Display(Name = "Platnost od")]
        public DateTime ValidFrom { get; set; }
        [Display(Name = "Platnost do")]
        public DateTime ValidTo { get; set; }
        [Display(Name = "Pojištěnec")]
        public int? InsuredId { get; set; } // cizí klíč
        [Display(Name = "Pojištěnec")]
        public Insured? Insured { get; set; } // navigační vlastnost
    }
}
