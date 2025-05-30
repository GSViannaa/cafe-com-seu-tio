namespace CafeComSeuTioAdmin.Data
{
    public interface IProductRepository
    {
        public void Add(Product product);
        public void Update(Product product);
       public Product GetById(int id);
       public List<Product> GetAll();
        public List<Product> GetAllFilter();
       public void DeleteById(int id);
        public void LogicalDeleteById(int id);



    }
}
