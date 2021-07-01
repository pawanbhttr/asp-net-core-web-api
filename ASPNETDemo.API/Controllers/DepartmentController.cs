using ASPNETDemo.Core.Entities;
using ASPNETDemo.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETDemo.API.Controllers
{
    [Route("api/department")]
    [ApiController]
    [Authorize]
    public class DepartmentController : ControllerBase
    {
        readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult GetDepartments([FromQuery] Department department)
        {
            return Ok(_departmentService.Get(department));
        }

        [HttpPost]
        public IActionResult PostDepartment([FromBody] Department department)
        {
            return Ok(_departmentService.Insert(department));
        }

        [HttpPut]
        public IActionResult PutDeparment([FromBody] Department department)
        {
            return Ok(_departmentService.Update(department));
        }

        [HttpDelete]
        public IActionResult DeleteDepartment([FromQuery] int departmentId)
        {
            return Ok(_departmentService.Delete(new Department() { DepartmentID = departmentId }));
        }
    }
}
