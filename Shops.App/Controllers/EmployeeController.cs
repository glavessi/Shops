using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Shops.BLL.DTO;
using Shops.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;        
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService service, ILogger<EmployeeController> log)
        {
            _service = service;
            _logger = log;
        }

        [HttpGet("/getAll")]
        public async Task<IActionResult> IndexAsync()
        {
            var model = await _service.GetAllEmployees();
            return View(model);
        }

        [HttpGet("/Create")]
        public async Task<IActionResult> Create()
        {
            var types = await _service.GetAllTypes();
            var typesList = new List<SelectListItem>();
            types.ForEach(x => {
                SelectListItem item = new SelectListItem(x.Name, x.TypeId.ToString());
                typesList.Add(item);
            });
            ViewBag.Types = typesList;
            EmployeeDTO model = new EmployeeDTO();            
            return View(model);
        }

        [HttpPost("/New")]
        public async Task<IActionResult> New([FromForm] EmployeeDTO dto)
        {
            await _service.AddEmployee(dto);
            return RedirectToAction("Index");
        }
    }
}
