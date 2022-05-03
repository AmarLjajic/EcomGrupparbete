using BookStoreProject.Data;
using BookStoreProject.Repository.IRepository;

namespace BookStoreProject.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private SqlContext _db;

        public UnitOfWork(SqlContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
