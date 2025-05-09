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
                var fileName = $"note-{DateTime.Now:yyyyMMdd}.txt";

                var productName = newProduct.Name;
                var path = Path.Combine("wwwroot/files", fileName);

                System.IO.File.WriteAllText(path, newProduct.ToString());

            }
        }
    }
}
