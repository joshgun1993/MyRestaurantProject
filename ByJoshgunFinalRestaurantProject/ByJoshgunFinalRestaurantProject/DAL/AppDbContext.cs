using ByJoshgunFinalRestaurantProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ByJoshgunFinalRestaurantProject.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MenuWater> MenuWaters { get; set; }
        public DbSet<Water> Waters { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<EmailMessage> EmailMessages { get; set; }



    }
}
