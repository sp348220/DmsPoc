using DocumentManagementSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CostomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(string Name,string Address,string MobileNumber,string Budget)
        {
            Customer cust = new Customer();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4J6IQKA\\SQLEXPRESS01;Initial Catalog=DocumentDb;Integrated Security=True;Trust Server Certificate=True;");
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer (Name, Address, MobileNumber, Budget) VALUES (@Name, @Address, @MobileNumber, @Budget)", con);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber);
            cmd.Parameters.AddWithValue("@Budget", Budget);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
            return View();
        }
    }
}
