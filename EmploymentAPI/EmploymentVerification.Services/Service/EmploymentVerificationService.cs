using EmploymentVerification.Implementation.Interface;
using EmploymentVerification.Models;
using EmploymentVerification.Services.Interface;

namespace EmploymentVerification.Services.Service
{
    public class EmploymentVerificationService : IEmploymentVerificationService
    {
        private readonly IEmployment _employment;

        public EmploymentVerificationService(IEmployment employment)
        {
            _employment = employment;
        }

        public EmploymentVerificationResponse VerifyEmployment(EmploymentVerificationRequest request)
        {
            if (request.EmployeeId <= 0 || string.IsNullOrWhiteSpace(request.CompanyName) || string.IsNullOrWhiteSpace(request.VerificationCode))
            {
                return new EmploymentVerificationResponse
                {
                    IsVerified = false,
                    Message = "Invalid request data. Please provide all fields."
                };
            }

            // Check if Employee exists by ID and Company Name

            var employee = _employment.GetEmployee(request.EmployeeId, request.CompanyName);

            if (employee == null)
            {
                return new EmploymentVerificationResponse
                {
                    IsVerified = false,
                    Message = "Employee not found. Please verify the Employee ID and Company Name."
                };
            }

            // Than Check Verification Code match or not

            if (employee.VerificationCode != request.VerificationCode)
            {
                return new EmploymentVerificationResponse
                {
                    IsVerified = false,
                    Message = "Not Verified. Verification code is incorrect."
                };
            }

            // If all checks passed

            return new EmploymentVerificationResponse
            {
                IsVerified = true,
                Message = "Verified"
            };
        }
    }
}
