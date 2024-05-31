using System.ComponentModel.DataAnnotations;

namespace mvc_project.Models.Movie
{
    public class CreateUpdateMovie
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Allowed length must be from 5 to 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Allowed length must be from 5 to 10 characters")]
        public string Category { get; set; }

        [Required(ErrorMessage = "In billboard is required")]
        public bool InBillboard { get; set; }
    }
}