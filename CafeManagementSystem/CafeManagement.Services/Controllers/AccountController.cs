using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
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
                return Ok(accrep.GetAccounts());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost("Create")]
        public IActionResult Create(Account acc)
        {
            try
            {
                return Ok(accrep.CreateAccount(acc));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
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
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
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
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
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
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("Update/Usr={username}")]
        public IActionResult Edit(Account acc, string username)
        {
            var usr = accrep.GetAccountByName(username);
            if (usr == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok(accrep.UpdateAccount(acc));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
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
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
