using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Required]
        public int Id { get; set; }
        [Required ]
        
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "must be between 3 and 100 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
