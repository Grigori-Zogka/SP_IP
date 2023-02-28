using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP_IP.Data;

namespace SP_IP.Controller
{
    public class IpController : Controller
    {
        private readonly IpDbContext _context;


       // constructor takes a data context 
        public IpController(IpDbContext context)
        {
            _context = context;
        }

        //method executes the stored procedure created in the DB and reutrns data to the view
        [HttpGet]
        public async Task<IActionResult> GetStoredProcData()
        {
            var results = await _context.IpModels
                .FromSqlInterpolated($"EXEC GetIpDetails")
                .ToListAsync();

            return View(results);
        }


    }
}
