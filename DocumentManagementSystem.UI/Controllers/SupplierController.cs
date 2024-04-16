using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.UI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SupplierController : Controller
    {
        private readonly IDeparmentService _departmentService;
        public SupplierController(IDeparmentService departmentService) 
        {
            _departmentService= departmentService;


        }
       
        public IActionResult Index() 
        {
            var departments =  _departmentService.GetAllAsync();
           // return this.ResponseView(departments);
            return View(departments);
        }
        public ActionResult getsupplier()
        {
            return View();
        }
    }
}
