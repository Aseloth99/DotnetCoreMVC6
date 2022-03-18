using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
        //prop tab
        [Key] //primary key
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [DisplayName("Display Order")]
        [Range(1,1000,ErrorMessage="Display Order must be between 1 and 100 only!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime{ get; set; } = DateTime.Now;
    }
}
