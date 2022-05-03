using BookStoreProject.Models;

namespace BookStoreProject.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
