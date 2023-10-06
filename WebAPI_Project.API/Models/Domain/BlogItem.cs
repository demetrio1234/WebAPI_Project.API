using System.ComponentModel.DataAnnotations;

namespace WebAPI_Project.API.Models.Domain {
    public class BlogItem {

        [Key]
        public Guid blog_item_id { get; set; }

        public string blog_item_title { get; set; }

        public string blog_item_description_short { get; set;}

        public string blog_item_description_long { get; set; }

        public string blog_item_image_url { get; set;}

        public string blog_item_url_handle { get;set;}

        public DateTime blog_item_publish_date { get; set; }

        public string blog_item_author { get; set; }

        public bool blog_item_isvisible { get; set;}

    }
}
