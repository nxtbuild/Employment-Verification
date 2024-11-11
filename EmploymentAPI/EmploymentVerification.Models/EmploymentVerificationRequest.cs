namespace EmploymentVerification.Models
{
    public class EmploymentVerificationRequest
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
