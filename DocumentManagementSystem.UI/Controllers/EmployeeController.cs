using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.Business.Services;
using DocumentManagementSystem.Dtos.EmployeeDtos;
using DocumentManagementSystem.UI.Extensions;
using DocumentManagementSystem.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetAllAsync();
            return this.ResponseView(emp);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
