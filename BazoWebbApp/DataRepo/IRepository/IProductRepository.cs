using BazoWebbApp.Models;

namespace BazoWebbApp.DataRepo.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
