using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagementSystemBackEnd.VModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagementSystemBackEnd.Controllers
{
    [Route("Camasy/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository rolrep;
        public RoleController(IRoleRepository roleRepository)
        {
            rolrep = roleRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<RoleVM> enumRoleVM = new();
                IEnumerable<Role> lisrol = rolrep.GetRoles();
                foreach(Role rol in lisrol)
                {
                    RoleVM rolvm = new()
                    {
                        RoleId = rol.RoleId,
                        Name = rol.Name
                    };
                    enumRoleVM.Add(rolvm);
                }
                if(enumRoleVM != null && enumRoleVM.Count() > 0)
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
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpPost("Create")]
        public IActionResult Create(RoleM rol)
        {
            try
            {
                Role rolobj = new()
                {
                    RoleId = rol.RoleId,
                    Name = rol.Name
                };
                return Ok(rolrep.CreateRole(rolobj));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpGet("Roid={id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = rolrep.GetRoleById(id);
                if (data != null)
                {
                    RoleVM rolobjvm = new()
                    {
                        RoleId =data.RoleId,
                        Name = data.Name
                    };
                    return Ok(rolobjvm);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpGet("Rona={rolename}")]
        public IActionResult GetByName(string rolename)
        {
            try
            {
                List<RoleVM> enumRoleVM = new();
                IEnumerable<Role> lisrol = rolrep.GetRolesByName(rolename);
                foreach (var rol in lisrol)
                {
                    RoleVM rolvm = new()
                    {
                        RoleId = rol.RoleId,
                        Name = rol.Name
                    };
                    enumRoleVM.Add(rolvm);
                }
                if (enumRoleVM != null && enumRoleVM.Count() > 0)
                {
                    return Ok(enumRoleVM.AsEnumerable());
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpPut("Update/Roid={id}")]
        public IActionResult Edit(RoleVM rolVM, int id)
        {
            var rol = rolrep.GetRoleById(id);
            if (rol == null)
            {
                return BadRequest();
            }
            try
            {
                rol.RoleId = rolVM.RoleId;
                rol.Name = rolVM.Name;
                return Ok(rolrep.UpdateRole(rol));
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpDelete("Delete/Roid={id}")]
        public IActionResult Delete(int id)
        {
            var rol = rolrep.GetRoleById(id);
            if (rol == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok(rolrep.DeleteRole(rol));
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}
