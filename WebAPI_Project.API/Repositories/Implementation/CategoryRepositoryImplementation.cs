using WebAPI_Project.API.DB;
using WebAPI_Project.API.Models.Domain;
using WebAPI_Project.API.Repositories.Interface;

namespace WebAPI_Project.API.Repositories.Implementation {
    public class CategoryRepositoryImplementation : ICategoryRepository {

        public ApplicationDbContext DbContext;

        public CategoryRepositoryImplementation(ApplicationDbContext dbContext) {
            DbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category) {

            await DbContext.Categories.AddAsync(category);//Passing the category to the "collection" of categories of our database context
            await DbContext.SaveChangesAsync();

            return category;
        }
    }
}
