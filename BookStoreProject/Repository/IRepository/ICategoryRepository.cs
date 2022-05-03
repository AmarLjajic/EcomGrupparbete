using BookStoreProject.Models;

namespace BookStoreProject.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<CategoryEntity>
    {
        void Update(CategoryEntity obj);
    }
}
