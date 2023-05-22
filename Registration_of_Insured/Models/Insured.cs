using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Registration_of_Insured.Models
{
    public class Insured
    {
        public int Id { get; set; }
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string Name { get; set; } = "";
        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string Surname { get; set; } = "";
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string Email { get; set; } = "";
        [Display(Name = "Telefoní číslo")]
        public int TelephoneNumber { get; set; }
        [Display(Name = "Ulice")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string Street { get; set; } = "";
        [Display(Name = "Číslo popisné")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public int HouseNumber { get; set; }
        [Display(Name = "Město")]
        [Required(ErrorMessage = "Pole je prázdné")]
        public string City { get; set; } = "";
        [Display(Name = "PSČ")]
        public int ZipCode { get; set; }
        public virtual ICollection<Insurance>? Insurances { get; set;}
    }
}
