using EmploymentVerification.Models;

namespace EmploymentVerification.Services.Interface
{
    public interface IEmploymentVerificationService
    {
        EmploymentVerificationResponse VerifyEmployment(EmploymentVerificationRequest request);
    }
}
