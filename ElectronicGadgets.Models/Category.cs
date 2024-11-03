using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ElectronicGadgets.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Company Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
