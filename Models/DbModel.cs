using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EshcApply.Models
{
    public class ApplicationsContext : DbContext
    {
        private string ConnString {get; set;}

        public ApplicationsContext(IConfiguration config) {
            ConnString = config.GetValue("DbConnectionString", "Host=localhost;Database=applications;Username=applications;Password=");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(ConnString);
    }

    public class ApplicationsUser : IdentityUser
    {
    }

    public class ApplicationsRole : IdentityRole
    {
    }
}