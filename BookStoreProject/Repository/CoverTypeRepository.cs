using BookStoreProject.Data;
using BookStoreProject.Models;
using BookStoreProject.Repository.IRepository;

namespace BookStoreProject.Repository
{
    public class CoverTypeRepository : Repository<CoverTypeEntity>, ICoverTypeRepository
    {
        private SqlContext _db;

        public CoverTypeRepository(SqlContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverTypeEntity obj)
        {
            _db.CoverTypes.Update(obj);
        } 
    }
}
