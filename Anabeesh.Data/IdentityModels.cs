using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Anabeesh.Data.Questions;
using System.ComponentModel.DataAnnotations;

namespace Anabeesh.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser()
        {
            Questions = new HashSet<Question>();
            Answers = new HashSet<Answer>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


        public virtual ICollection<Question> Questions { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public byte Country { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public long NumberOfFollowers { get; set; }

        [Required]
        public long NumberOfFollowing { get; set; }

        [Required]
        public long NumberOfQuestions { get; set; }

        [Required]
        public long NumberOfAnswers { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<MainCategory> MainCategories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Question> Questions { get; set; }



    }
}
