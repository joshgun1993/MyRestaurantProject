using System.Collections.Generic;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class ChangeRoleVM
    {
        public string OldRole { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public List<string> Roles { get; set; }
    }
}
