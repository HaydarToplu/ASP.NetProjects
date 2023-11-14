using ASP_.NET__Projects.Services;
using D8_HospitalManagementSystem;
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
    public IActionResult AddHospital([FromForm] string hospitalName)
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
   
     
    
    [HttpPost(Name = "Employee")]
    public IActionResult AddEmployee([FromBody] Doctor employee)
    {
        _hospitalService.AddEmployee(employee);
        return Ok("Success");
    }
    
    [HttpGet("{employeeName}")]
     public IActionResult ShowEmployees([FromRoute] string employeeName)
     {
         var employee = _hospitalService.ShowEmployees(employeeName);
         if (employee == null)
         {
             return NotFound("Employee Not Found !");
         }
         return Ok(employee);
     }

}