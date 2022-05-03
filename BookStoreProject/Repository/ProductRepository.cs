using BookStoreProject.Data;
using BookStoreProject.Models;
using BookStoreProject.Repository.IRepository;

namespace BookStoreProject.Repository
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        private SqlContext _db;

        public ProductRepository(SqlContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductEntity obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Author = obj.Author;
                objFromDb.CoverType = obj.CoverType;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    }
}
