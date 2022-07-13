using ByJoshgunFinalRestaurantProject.Models;
using System.Collections.Generic;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class DashboardVM
    {
        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
        public List<Menu> Menus { get; set; }
        //public List<MenuWater> MenuWater { get; set; }
    }
}
