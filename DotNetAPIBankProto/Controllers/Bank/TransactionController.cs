using Microsoft.AspNetCore.Mvc;
using TemplateBackend.Data;
using TemplateBackend.Models;
using System.Linq;

namespace TemplateBackend.Controllers.Bank
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTransactions()
        {
            return Ok(_context.Transactions.ToList());
        }

        [HttpPost]
        public IActionResult CreateTransaction([FromBody] Transaction transaction)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Id == transaction.AccountId);
            if (account == null)
                return NotFound("Account not found");

            if (transaction.TransactionType == "Debit" && account.Balance < transaction.Amount)
                return BadRequest("Insufficient balance");

            account.Balance += transaction.TransactionType == "Credit" ? transaction.Amount : -transaction.Amount;

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return Ok(transaction);
        }
    }
}