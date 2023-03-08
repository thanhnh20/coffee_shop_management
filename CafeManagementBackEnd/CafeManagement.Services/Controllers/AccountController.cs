using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Services.API.Services;
using CafeManagement.Services.API.VModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.Services.API.Controllers
{
    [Route("Camasy/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices accrep;

        private readonly IRoleServices rolrep;
        public AccountController(IAccountServices accountServices,IRoleServices roleServices)
        {
            accrep = accountServices;
            rolrep = roleServices;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<AccountVM> enumAccountVM = accrep.GetAccounts();
                if (enumAccountVM != null && enumAccountVM.Count() > 0)
                {
                    return Ok(enumAccountVM);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
        [HttpPost("Create")]
        public IActionResult Create(AccountM acc)
        {
            try
            {
                var rol = rolrep.GetRoleById(acc.RoleId);
                if (rol == null) return StatusCode(StatusCodes.Status404NotFound, "Role Not Found!".ToString());
                AccountVM accountVM = accrep.CreateAccount(acc);
                if (accountVM != null)
                {
                    return Ok(accountVM);
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
        [HttpPost("Register")]
        public IActionResult Register(AccountM acc)
        {
            try
            {
                var rol = rolrep.GetRoleById(acc.RoleId);
                if (rol == null) return StatusCode(StatusCodes.Status404NotFound, "Role Not Found!".ToString());
                AccountVM accountVM = accrep.CreateAccount(acc);
                if (accountVM != null)
                {
                    return Ok(accountVM);
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
        [HttpGet("Usr={username}")]
        public IActionResult GetByUsername(string username)
        {
            try
            {
                AccountVM enumaccountVM = accrep.GetAccountByName(username);
                if(enumaccountVM != null)
                {
                    return Ok(enumaccountVM);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpGet("Usr={username}&Pwd={password}")]
        public IActionResult Login(string username, string password)
        {
            try
            {
                var data = accrep.GetAccountByNameAndPass(username, password);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpGet("Stf={staffid}")]
        public IActionResult GetByStaffId(int staffid)
        {
            try
            {
                var data = accrep.GetAccountByStaff(staffid);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpPut("Update/Usr={username}")]
        public IActionResult Edit(AccountVM acc, string username)
        {
            try
            {
                AccountVM accountVM = accrep.UpdateAccount(acc,username);
                if(accountVM != null)
                {
                    return Ok(accountVM);
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.InnerException.Message);
            }
        }
        [HttpDelete("Delete/Usr={username}")]
        public IActionResult Delete(string username)
        {
            try
            {
                bool success = accrep.DeleteAccount(username);
                if(success)
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
