using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbcontext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDbcontext db)
        {
            _db = db;
        }

        
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }

    }
}
