using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    /*
     * Data annotations allow to use entity framework and perform typical sql actions here
     */
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now; // Default value
    }
}
