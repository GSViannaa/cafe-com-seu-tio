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
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (EditProduct.Upload is not null)
                {
                    EditProduct.ImageFileName = EditProduct.Upload.FileName;

                    var file = Path.Combine(webEnv.ContentRootPath,
                                "wwwroot/images/menu", EditProduct.Upload.FileName);

                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await EditProduct.Upload.CopyToAsync(fileStream);
                    }
                }


            }

            return RedirectToPage("ViewAllProducts", new { id = EditProduct.Id });
        }
    }
}

