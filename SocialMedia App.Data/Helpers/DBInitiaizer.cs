using Microsoft.EntityFrameworkCore.Metadata;
using SocialMedia_App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_App.Data.Helpers
{
    public static class DBInitiaizer
    {
        public static async Task SeedAsync(AppDbContext appDbContext)
        {
            if (!appDbContext.Users.Any() && !appDbContext.Posts.Any()) {

                var newUser = new User()
                {
                    FullName = "Anders",
                    ProfilePictureUrl = ""
                };

                await appDbContext.Users.AddAsync(newUser);
                await appDbContext.SaveChangesAsync();

                var newPostWithOutImage = new Post()
                {
                    Content = "First post from db",
                    ImageUrl = "",
                    NrOfReports = 0,
                    Created = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,

                    UserId = newUser.Id
                };


                var newPostWithImage = new Post()
                {
                    Content = "First DB post, has image",
                    ImageUrl = "",
                    NrOfReports = 0,
                    Created = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,

                };

                await appDbContext.Posts.AddRangeAsync(newPostWithOutImage, newPostWithImage);
                await appDbContext.SaveChangesAsync();

            }
        }
    }
}
