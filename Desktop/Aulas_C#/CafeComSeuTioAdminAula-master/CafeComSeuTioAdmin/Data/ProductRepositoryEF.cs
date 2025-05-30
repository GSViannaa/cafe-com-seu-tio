
namespace CafeComSeuTioAdmin.Data
{
    public class ProductRepositoryEF : IProductRepository
    {

        CafeContext _context { get; set; }
        public ProductRepositoryEF(CafeContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void LogicalDeleteById(int id)
        {
            var product = _context.Products.First(x => x.Id == id);
            product.Deleted = false;
            _context.SaveChanges();
        }
        public void DeleteById(int id)
        {
            var deleteItem = _context.Products.First(x => x.Id == id);
            _context.Products.Remove(deleteItem);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.First(x => x.Id == id);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllFilter()
        {
            return _context.Products.Where(x => x.Deleted == false).ToList();
        }
    }
}
