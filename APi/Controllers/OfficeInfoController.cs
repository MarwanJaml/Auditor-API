using APi.Data;
using APi.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeInfoController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public OfficeInfoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/OfficeInfo
        [HttpGet]
        public async Task<ActionResult<List<OfficeInfo>>> GetOffices()
        {
            var offices = await _dbContext.OfficeInfos.ToListAsync();
            return Ok(offices);
        }

        // GET: api/OfficeInfo/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<OfficeInfo>> GetOffice(int id)
        {
            var office = await _dbContext.OfficeInfos.FindAsync(id);
            if (office == null)
                return NotFound($"Office with ID {id} not found.");
            return Ok(office);
        }

        // POST: api/OfficeInfo
        [HttpPost]
        public async Task<ActionResult> AddOffice([FromBody] OfficeInfo newOffice)
        {
            if (await _dbContext.OfficeInfos.AnyAsync(o => o.Id == newOffice.Id))
                return BadRequest($"Office with ID {newOffice.Id} already exists.");

            _dbContext.OfficeInfos.Add(newOffice);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOffice), new { id = newOffice.Id }, newOffice);
        }

        // PUT: api/OfficeInfo/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOffice(int id, [FromBody] OfficeInfo updatedOffice)
        {
            var office = await _dbContext.OfficeInfos.FindAsync(id);
            if (office == null)
                return NotFound($"Office with ID {id} not found.");

            // Update properties
            office.OfficeName = updatedOffice.OfficeName;
            office.PhoneNumbers = updatedOffice.PhoneNumbers;
            office.Emails = updatedOffice.Emails;
            office.TaxNumber = updatedOffice.TaxNumber;
            office.CertifiedAccountants = updatedOffice.CertifiedAccountants;
            office.Employees = updatedOffice.Employees;
            office.LicensedAccountants = updatedOffice.LicensedAccountants;
            office.LicenseNumbers = updatedOffice.LicenseNumbers;
            office.ExpectedBudgets = updatedOffice.ExpectedBudgets;

            await _dbContext.SaveChangesAsync();
            return Ok(new { message = "Office info updated successful" });
        }

        // DELETE: api/OfficeInfo/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOffice(int id)
        {
            var office = await _dbContext.OfficeInfos.FindAsync(id);
            if (office == null)
                return NotFound($"Office with ID {id} not found.");

            _dbContext.OfficeInfos.Remove(office);
            await _dbContext.SaveChangesAsync();
            return Ok(new { message = "Office info deleted successful" });
        }
    }
}
