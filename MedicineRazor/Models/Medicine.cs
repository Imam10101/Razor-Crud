using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace MedicineRazor.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Strength { get; set; }
        public string Group { get; set; }
        public int  Price { get; set; }
    }
}
