using System.ComponentModel.DataAnnotations;

namespace SocialMedia_App.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Content {  get; set; }

        public string? ImageUrl { get; set; }

        public int NrOfReports { get; set; }

        public DateTime? Created { get; set; }

        public DateTime DateUpdated { get; set; }


    }
}
