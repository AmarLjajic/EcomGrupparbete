using BookStoreProject.Data;
using BookStoreProject.Models;
using BookStoreProject.Repository.IRepository;

namespace BookStoreProject.Repository
{
    public class CategoryRepository : Repository<CategoryEntity>, ICategoryRepository
    {
        private SqlContext _db;

        public CategoryRepository(SqlContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CategoryEntity obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
