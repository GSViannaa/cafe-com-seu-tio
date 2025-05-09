using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class addproductModel : PageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
           if(ModelState.IsValid)
            {

            }
        }
    }
}
