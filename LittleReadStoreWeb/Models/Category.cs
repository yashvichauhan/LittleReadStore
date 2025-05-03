using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LittleReadStoreWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot be longer than 50 characters!")]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Range(1, 100,ErrorMessage ="Display Order must be between 1 and 100!")]
        [DisplayName("Display Order")]
        public string DisplayOrder { get; set; }
    }
}
