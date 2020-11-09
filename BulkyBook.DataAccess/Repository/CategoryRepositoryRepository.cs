using BulkyBook.DataAccess.Data;

namespace BulkyBook.DataAccess.Repository
{
    internal class CategoryRepositoryRepository : ICategoryRepositorty
    {
        private ApplicationDbContext _db;

        public CategoryRepositoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}