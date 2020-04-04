using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models;
using MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasterDegreeIndustrialComputerScience.Api.Feature.AdvancedDatabasesArchitecture.VirtualDean
{
    [Route("api/[controller]")]
    [ApiController]
    public class VirtualDeanController : ControllerBase
    {
        private StudentService StudentService;
        public VirtualDeanController()
        {
            StudentService = new StudentService("mongodb://localhost");
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            try
            {
                return StudentService.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public async Task PostStudent([FromBody] Student student)
        {
            try
            {
                StudentService.Create(student);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        
        }
    }
}