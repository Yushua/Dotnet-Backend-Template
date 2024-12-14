using Microsoft.AspNetCore.Mvc;
using TemplateBackend.Data;
using TemplateBackend.Models;
using System.Linq;

namespace TemplateBackend.Controllers.Bank
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAccounts()
        {
            return Ok(_context.Accounts.ToList());
        }

        [HttpPost]
        public IActionResult CreateAccount([FromBody] Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return Ok(account);
        }
    }
}