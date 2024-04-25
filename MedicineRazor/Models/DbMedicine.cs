using Microsoft.EntityFrameworkCore;

namespace MedicineRazor.Models
{
    public class DbMedicine:DbContext
    {
        public DbMedicine(DbContextOptions<DbMedicine> options): base(options) 
        {
               
        }
        public DbSet<Medicine> Medicines { get; set;}
    }
}
