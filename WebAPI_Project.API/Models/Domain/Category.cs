using System.ComponentModel.DataAnnotations;

namespace WebAPI_Project.API.Models.Domain {
    public class Category {
        [Key]
        public Guid Category_id { get; set; }

        public string Category_name { get; set; } = string.Empty;

        public string Category_url_handle { get; set; } = string.Empty;

    }
}
