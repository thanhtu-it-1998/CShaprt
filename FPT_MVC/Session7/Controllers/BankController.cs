using Session7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Session7.Controllers
{
    public class BankController : ApiController
    {
        private readonly DB_BankEntities _context = new DB_BankEntities();

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Create")]
        public IHttpActionResult Create(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                IFSC = bankModel.IFSC
            };
            _context.Table_DB_Bank.Add(bank);
            _context.SaveChanges();
            return Ok("Success");
        }
        
        [HttpGet]
        [Authorize]
        [Route("api/Bank/GetAll")]
        public IHttpActionResult GetAll()
        {
            var banks = _context.Table_DB_Bank.ToList();
            return Ok(banks);
        }
    }
}
