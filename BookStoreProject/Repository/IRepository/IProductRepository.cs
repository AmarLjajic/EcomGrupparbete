using BookStoreProject.Models;

namespace BookStoreProject.Repository.IRepository
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        void Update(ProductEntity obj);
    }
}
