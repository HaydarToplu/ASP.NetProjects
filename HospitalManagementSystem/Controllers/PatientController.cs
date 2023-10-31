using D8_HospitalManagementSystem;
using Microsoft.AspNetCore.Mvc;

namespace ASP_.NET__Projects.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PatientController : ControllerBase
{
    private readonly ILogger<PatientController> _logger;

    public PatientController(ILogger<PatientController> logger)
    {
        _logger = logger;
    }
    private List<Patient> Patients = new List<Patient>();

    [HttpPost( "Patient")]
    public IActionResult AddPatient([FromForm] Patient patient)
    {
        Patients.Add(patient);
        return Ok();
    }

    [HttpGet("Patient")]
    public IEnumerable<Patient> ShowPatients()
    {
        foreach (Patient patient in Patients)
        {
            yield return patient;
        }
    }
}