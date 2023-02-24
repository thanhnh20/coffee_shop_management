using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Services.VModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagementSystemBackEnd.Controllers
{
    [Route("Camasy/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accrep;
        public AccountController(IAccountRepository accountRepository)
        {
            accrep = accountRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<AccountVM> enumAccountVM = new();
                IEnumerable<Account> lisacc = accrep.GetAccounts();
                foreach (Account acc in lisacc)
                {
                    AccountVM accvm = new()
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        RoleId = acc.RoleId,
                        Status = acc.Status
                    };
                    enumAccountVM.Add(accvm);
                }
                if (enumAccountVM != null && enumAccountVM.Count() > 0)
                {
                    return Ok(enumAccountVM.AsEnumerable());
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
        public IActionResult Create(AccountM acc)
        {
            try
            {
                Account accobj = new()
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    RoleId = acc.RoleId,
                    Status = acc.Status
                };
                return Ok(accrep.CreateAccount(accobj));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpGet("Usr={username}")]
        public IActionResult GetByUsername(string username)
        {
            try
            {
                var data = accrep.GetAccountByName(username);
                if (data != null)
                {
                    Account accobj = new()
                    {
                        Username = data.Username,
                        Password = data.Password,
                        RoleId = data.RoleId,
                        Status = data.Status
                    };
                    return Ok(accobj);
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
        [HttpGet("Usr={username}&Pwd={password}")]
        public IActionResult GetByUsernameAndPassword(string username,string password)
        {
            try
            {
                var data = accrep.GetAccountByNameAndPass(username,password);
                if (data != null)
                {
                    Account accobj = new()
                    {
                        Username = data.Username,
                        Password = data.Password,
                        RoleId = data.RoleId,
                        Status = data.Status
                    };
                    return Ok(accobj);
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
        [HttpGet("Stf={staffid}")]
        public IActionResult GetByStaffId(int staffid)
        {
            try
            {
                var data = accrep.GetAccountByStaff(staffid);
                if (data != null)
                {
                    Account accobj = new()
                    {
                        Username = data.Username,
                        Password = data.Password,
                        RoleId = data.RoleId,
                        Status = data.Status
                    };
                    return Ok(accobj);
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
        [HttpPut("Update/Usr={username}")]
        public IActionResult Edit(AccountVM acc, string username)
        {
            var usr = accrep.GetAccountByName(username);
            if (usr == null)
            {
                return BadRequest();
            }
            try
            {
                usr.Password = acc.Password;
                usr.RoleId = acc.RoleId;
                usr.Status = acc.Status;
                return Ok(accrep.UpdateAccount(usr));
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
        [HttpDelete("Delete/Usr={username}")]
        public IActionResult Delete(string username)
        {
            var usr = accrep.GetAccountByName(username);
            if (usr == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok(accrep.DeleteAccount(usr));
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,e);
            }
        }
    }
}
