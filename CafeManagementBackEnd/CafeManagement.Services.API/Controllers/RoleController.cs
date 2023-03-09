using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Services.API.Services;
using CafeManagement.Services.API.VModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Services.API.Controllers
{
    [Route("Camasy/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleServices rolser;
        public RoleController(IRoleServices roleServices)
        {
            rolser = roleServices;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<RoleVM> enumRoleVM = rolser.GetRoles();
                if (enumRoleVM != null && enumRoleVM.Count() > 0)
                {
                    return Ok(enumRoleVM.AsEnumerable());
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound);
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpPost("Create")]
        public IActionResult Create(RoleM rol)
        {
            try
            {
                RoleVM roleVM = rolser.CreateRole(rol);
                if (roleVM != null)
                {
                    return Ok(roleVM);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpGet("Roid={id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                RoleVM enumRoleVM = rolser.GetRoleById(id);
                if (enumRoleVM != null)
                {
                    return Ok(enumRoleVM);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpGet("Rona={rolename}")]
        public IActionResult GetByName(string rolename)
        {
            try
            {
                IEnumerable<RoleVM> enumRoleVM = rolser.GetRolesByName(rolename);
                if (enumRoleVM != null && enumRoleVM.Count() > 0)
                {
                    return Ok(enumRoleVM.AsEnumerable());
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpPut("Update/Roid={id}")]
        public IActionResult Edit(RoleVM rolVM, int id)
        {
            try
            {
                RoleVM roleVM = rolser.UpdateRole(rolVM,id);
                if (roleVM != null)
                {
                    return Ok(roleVM);
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpDelete("Delete/Roid={id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool success = rolser.DeleteRole(id);
                if (success)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
    }
}
