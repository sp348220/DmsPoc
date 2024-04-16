using DocumentManagementSystem.DataAccess.Contexts;
using DocumentManagementSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DocumentManagementSystem.DataAccess.Contexts;

namespace DocumentManagementSystem.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController(DocumentContext context)
        {
            Context = context;
        }

        public DocumentContext Context { get; }
        [HttpDelete("DeleteEmployee")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployeeMaster(int Id)
        {

            // int x = Convert.ToInt32(Id);
            var data = await Context.EmployeeMaster.FindAsync(Id);
            if (data == null)
            {
                return BadRequest();
            }
            Context.Remove(data);
            ; await Context.SaveChangesAsync();
            return Ok(data);
        }
    }
}
