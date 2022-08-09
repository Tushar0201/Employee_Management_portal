using System.Collections.Generic;

namespace EmployeeManagement.ViewModels
{
    public class EditRoles
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
