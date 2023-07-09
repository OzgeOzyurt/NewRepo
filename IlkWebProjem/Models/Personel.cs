using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace IlkWebProjem.Models
{
    public class Personel
    {
        [Display(Name = "Personel Adı")]
        [StringLength(50, ErrorMessage = "Bu alana en fazla 50 karakter yazılabilir")]
        public string Ad { get; set; }

        [DisplayName("Personel Soyadı")]
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public bool Aktif { get; set; }

    }
}
