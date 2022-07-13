using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeactive { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
    }
}
