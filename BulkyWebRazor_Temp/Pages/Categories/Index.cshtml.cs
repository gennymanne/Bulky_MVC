using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbcontext _db;
        public List<Category> CategoryList {get; set; }
        public IndexModel(ApplicationDbcontext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList= _db.Categories.ToList();  
        }
    }
}
