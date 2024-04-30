using System.ComponentModel.DataAnnotations;

namespace BazoWebbRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order for category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
