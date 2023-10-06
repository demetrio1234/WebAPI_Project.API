using Microsoft.AspNetCore.Mvc;
using WebAPI_Project.API.Models.Domain;
using WebAPI_Project.API.Models.DTO;
using WebAPI_Project.API.Repositories.Interface;

//https://localhost:7100/api/categories
namespace WebAPI_Project.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase {

        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository) {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDTO request) {

            //MapExtensions the DTO to the Domain Model
            Category category = new Category {

                Category_name = request.Category_name,
                Category_url_handle = request.Category_url_handle,

            };

            await categoryRepository.CreateAsync(category);
            
            //Since through our response we do not want to expose the entire model
            //we need to map the new created category to a correspondent DTO,
            //then we can return through the response object just what we want of the dto
            //Create a new categorydto
            var response = new CategoryDTO {
                Category_dto_id = category.Category_id,
                Category_dto_name = category.Category_name,
                Category_dto_urlhandle = category.Category_url_handle,
            };

            return Ok(response);
        }



    }
}
