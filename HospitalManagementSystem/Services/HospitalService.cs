using D8_HospitalManagementSystem;

namespace ASP_.NET__Projects.Services;

public class HospitalService
{
    private List<Hospital> Hospitals = new List<Hospital>();
    private List<IEmployee> Employees = new List<IEmployee>();

    public bool AddHospital(string hospitalName)
    {
        Hospitals.Add(new Hospital {Name = hospitalName});
        return true;
    }
    
    public Hospital? GetHospital(string hospitalName)
    {
        return Hospitals.FirstOrDefault(h => h.Name == hospitalName);
    }

    public bool AddEmployee(IEmployee employee)
    {
        Employees.Add(new Doctor {
            Id = employee.Id, 
            Name = employee.Name , 
            Surname = employee.Surname , 
            Sex = employee.Sex,
            Job = Jobs.Doctor.ToString(),
            Rank = 1 ,
            MaxRank = 3,
            Salary = employee.Salary,
            DateOfRec = DateTime.Now, 
            DateOfFired = null
            
        } );
        return true;
    }

    public IEmployee? ShowEmployees(string empName)
    {
        return Employees.FirstOrDefault(e => e.Name == empName);
    }

}
