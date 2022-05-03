using BookStoreProject.Models;

namespace BookStoreProject.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverTypeEntity>
    {
        void Update(CoverTypeEntity obj);
    }
}
