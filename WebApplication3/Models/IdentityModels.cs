using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //this is where I can define additional properties for ApplicationUser class
        //which will be reflected inside AspNetUsers table


        [Required] //data annotations allow me to define information, 
        [MaxLength(200)] //based on which model validation will be perfomed, 
        [Display(Name = "E-mail")] //and also the shape field in the table
        public string Email { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    { //ApplicationDbContext is instantiated base on ApplicationUser class, where we have our Email field defined
        public ApplicationDbContext()
            : base("DefaultConnection") //name of the database connection stored in Web.Config file
        {
        }
    }
}