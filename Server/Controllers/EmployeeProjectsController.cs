using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Coursework.Server.Data;
using Coursework.Shared;

namespace Coursework.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeProjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeProject>>> GetEmployeeProject()
        {
            return await _context.EmployeeProject.ToListAsync();
        }

        // GET: api/EmployeeProjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeProject>> GetEmployeeProject(Guid id)
        {
            var employeeProject = await _context.EmployeeProject.FindAsync(id);

            if (employeeProject == null)
            {
                return NotFound();
            }

            return employeeProject;
        }

        // PUT: api/EmployeeProjects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeProject(Guid id, EmployeeProject employeeProject)
        {
            if (id != employeeProject.EmployeeProjectId)
            {
                return BadRequest();
            }

            _context.Entry(employeeProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployeeProjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeProject>> PostEmployeeProject(EmployeeProject employeeProject)
        {
            _context.EmployeeProject.Add(employeeProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeProject", new { id = employeeProject.EmployeeProjectId }, employeeProject);
        }

        // DELETE: api/EmployeeProjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeProject(Guid id)
        {
            var employeeProject = await _context.EmployeeProject.FindAsync(id);
            if (employeeProject == null)
            {
                return NotFound();
            }

            _context.EmployeeProject.Remove(employeeProject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeProjectExists(Guid id)
        {
            return _context.EmployeeProject.Any(e => e.EmployeeProjectId == id);
        }
    }
}
