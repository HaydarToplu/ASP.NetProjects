using D8_HospitalManagementSystem;

namespace ASP_.NET__Projects.Services;

public class HospitalService
{
    private List<Hospital> Hospitals = new List<Hospital>();

    public bool AddHospital(string hospitalName)
    {
        Hospitals.Add(new Hospital {Name = hospitalName});
        return true;
    }
    
    public Hospital? GetHospital(string hospitalName)
    {
        return Hospitals.FirstOrDefault(h => h.Name == hospitalName);
    }
}