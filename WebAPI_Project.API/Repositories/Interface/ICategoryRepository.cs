using WebAPI_Project.API.Models.Domain;

namespace WebAPI_Project.API.Repositories.Interface
{
    public interface ICategoryRepository
    {

        Task<Category> CreateAsync(Category category);



    }
}
