using BookStoreProject.Data;
using BookStoreProject.Models;
using BookStoreProject.Repository.IRepository;

namespace BookStoreProject.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private SqlContext _db;

        public CompanyRepository(SqlContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        } 
    }
}
