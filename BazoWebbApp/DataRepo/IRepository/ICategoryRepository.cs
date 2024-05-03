using BazoWebbApp.Models;

namespace BazoWebbApp.DataRepo.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
