using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class EditModel : PageModel
    {
        private IWebHostEnvironment webEnv;
        private IProductRepository _productRepository;

        [BindProperty]
        public Product EditProduct { get; set; }
        public List<Product> Products { get; set; }

        [FromRoute]
        public int id { get; set; }

        public EditModel(IProductRepository Irepository, IWebHostEnvironment webEnv)
        {
            //this.cafeContext = context;
            this.webEnv = webEnv;
            _productRepository = Irepository;


        }


        public void OnGet()
        {
            EditProduct= _productRepository.GetById(id);

                
         }


        public async Task<IActionResult> OnPostDelete()
        {
            _productRepository.LogicalDeleteById(id);

            return RedirectToPage("ViewAllProducts", new { id = EditProduct.Id });
        }

        public async Task<IActionResult> OnPostEdit()
        {
               EditProduct.Id = id;
               EditProduct.Created = DateTime.Now;
              EditProduct.Deleted = true;


             _productRepository.Update(EditProduct);

            return RedirectToPage("ViewAllProducts", new { id = EditProduct.Id });
        }
    }
}

