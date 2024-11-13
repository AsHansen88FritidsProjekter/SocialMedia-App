using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_App.Data.Models
{
     public class User
    {

        public int Id { get; set; }

        public string FullName { get; set; }
        
        public string ProfilePictureUrl {  get; set; }

        // navigation properties

        public ICollection<Post> Posts { get; set; } = new List<Post>();

    }
}
