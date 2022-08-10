using System.Collections.Generic;

namespace EmployeeManagement.ViewModels
{
    public class EditRoles
    {

        public EditRoles()
        {
            Users = new List<string>();
        }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
