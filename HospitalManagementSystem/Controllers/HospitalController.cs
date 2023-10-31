using ASP_.NET__Projects.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET__Projects.Controllers;

// Hospital Controllers
[ApiController]
[Route("[controller]/[action]")]
public class HospitalController : ControllerBase
{
    private readonly ILogger<HospitalController> _logger;
    private readonly HospitalService _hospitalService;

    // Controller -> Service -> Repository -> (Database)
    
    public HospitalController(ILogger<HospitalController> logger, HospitalService hospitalService)
    {
        _hospitalService = hospitalService;
        _logger = logger;
    }
    
    [HttpPost(Name = "Hospital")]
    public IActionResult AddHospital([FromBody] string hospitalName)
    {
        _hospitalService.AddHospital(hospitalName);
        return Ok("Success");
    }
    
    [HttpGet]
    public IActionResult GetHospital(string hospitalName)
    {
        var hospital = _hospitalService.GetHospital(hospitalName);
        if (hospital == null)
        {
            return NotFound();
        }
        return Ok(hospital);
    }
    //
    // private List<IEmployee> Employees = new List<IEmployee>();
    //
    // [HttpPost(Name = "Employee")]
    // public IActionResult AddEmployee([FromForm] IEmployee employee)
    // {
    //     Employees.Add(employee);
    //     return Ok();
    // }
    //
    // [HttpGet]
    // public IActionResult ShowEmployees()
    // {
    //     if (Employees == null)
    //     {
    //         return NotFound();
    //     }
    //     return Ok(Employees);
    // }

}