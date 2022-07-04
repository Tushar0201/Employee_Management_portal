using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
namespace EmployeeManagement.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employee emp { get; set; }
        public string pageTitle { get; set; }
    }
}
