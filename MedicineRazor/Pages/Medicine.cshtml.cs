using MedicineRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineRazor.Pages
{
    public class MedicineModel : PageModel
    {
        private readonly DbMedicine _context;
        public List<Medicine> allmedicines = new List<Medicine>();
        public MedicineModel(DbMedicine context)
        {
           this._context = context;
      
        }
        [BindProperty]
        public Medicine InputMedicine { get; set; }


        public void OnGet()
        {
            allmedicines = _context.Medicines.ToList();
        }
        public IActionResult OnPost()
        {
            var ifExists = _context.Medicines.Any(p => p.Name == InputMedicine.Name);

            if (!ifExists)

            {
                _context.Medicines.Add(InputMedicine);
                _context.SaveChanges();
            }
            else
            {
                TempData["m"] = "Medicine already exists .Try another one.";
            }
            return RedirectToPage();

        }
        public IActionResult OnPostDelete(int Id)
        {
            var medicine = _context.Medicines.Find(Id);

            _ = _context.Medicines.Remove(medicine);
            _context.SaveChanges();

            return RedirectToPage();
        }

    }
}
