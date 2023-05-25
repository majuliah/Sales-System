using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Models;

namespace SalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department{ Id = 001, Name = "Eletronics" });
            departments.Add(new Department{ Id = 002, Name = "Fashion" });
            departments.Add(new Department{ Id = 003, Name = "Games" });

            return View(departments);
        }
    }
}
