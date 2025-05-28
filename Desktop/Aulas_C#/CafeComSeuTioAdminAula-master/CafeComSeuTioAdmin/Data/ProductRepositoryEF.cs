
namespace CafeComSeuTioAdmin.Data
{
    public class ProductRepositoryEF : IProductRepository
    {

        CafeContext _context { get; set;  }
        public ProductRepositoryEF(CafeContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllFilter()
        {
            return _context.Products.Where(x => x.Deleted == false).ToList();
        }
    }
}
