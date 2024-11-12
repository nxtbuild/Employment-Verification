using EmploymentVerification.Implementation.Interface;
using EmploymentVerification.Models;

namespace EmploymentVerification.Implementation.Repositories
{
    public class EmploymentRepository : IEmployment
    {
        private readonly List<EmploymentRecord> _employees = new List<EmploymentRecord>
        {
            new EmploymentRecord { EmployeeId = 1, CompanyName = "Test Company A", VerificationCode = "XYZ-007" },
            new EmploymentRecord { EmployeeId = 2, CompanyName = "Test Company B", VerificationCode = "XYZ-764" },
            new EmploymentRecord { EmployeeId = 3, CompanyName = "Test Company C", VerificationCode = "XYZ-432" },
            new EmploymentRecord { EmployeeId = 4, CompanyName = "Test Company D", VerificationCode = "XYZ-890" },
            new EmploymentRecord { EmployeeId = 5, CompanyName = "Test Company E", VerificationCode = "XYZ-901" },
        };

        public EmploymentRecord GetEmployee(int employeeId, string companyName)
        {
            return _employees.FirstOrDefault(emp =>
                                             emp.EmployeeId == employeeId &&
                                             emp.CompanyName==companyName);
        }
    }
}
