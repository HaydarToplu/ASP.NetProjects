using D8_HospitalManagementSystem;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET__Projects.Controllers;

// Hospital Controllers
[ApiController]
[Route("[controller]/[action]")]
public class HospitalController : ControllerBase
{
    private readonly ILogger<HospitalController> _logger;
    
    public HospitalController(ILogger<HospitalController> logger)
    {
        _logger = logger;
    }
    
    private static List<Hospital> Hospitals = new List<Hospital>();
    
    [HttpPost(Name = "Hospital")]
    public IActionResult AddHospital([FromBody] Hospital hospital)
    {
        Hospitals.Add(hospital);
        return Ok();
    }
    
    [HttpGet]
    public IActionResult GetHospital(string hospitalName)
    {
        var hospital = Hospitals.FirstOrDefault(h => h.Name == hospitalName);
        if (hospital == null)
        {
            return NotFound();
        }
        return Ok(hospital);
    }

    private List<IEmployee> Employees = new List<IEmployee>();

    [HttpPost(Name = "Employee")]
    public IActionResult AddEmployee([FromForm] IEmployee employee)
    {
        Employees.Add(employee);
        return Ok();
    }
    
    [HttpGet]
    public IActionResult ShowEmployees()
    {
        if (Employees == null)
        {
            return NotFound();
        }
        return Ok(Employees);
    }

}