using EmploymentVerification.Models;

namespace EmploymentVerification.Implementation.Interface
{
    public interface IEmployment
    {
        EmploymentRecord GetEmployee(int employeeId, string companyName);
    }
}
