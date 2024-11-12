
## Overview

This is the ASP.NET Core Web API Project with endpoint:  POST /api/verify-employment

## Technologies Used

- .NET 8
- ASP.NET Core Web API
- In-memory data structure
- Dependency Injection
  
### Steps to Run The API

1. Open Visual Studio 2022
2. Project code in master branch
3. Clone the Repository
   git clone https://github.com/nxtbuild/Employment-Verification-API.git



## Project Structure

**EmploymentVerification.API**
  Here in this project, I imeplement the controller, inject the service in constructor
  
**EmploymentVerification.Implementation**
   In this project, I create a interface and define the GetEmployee method which received the paramenter and implement the
   EmploymentRepository, create the in memory data by using List and provide the EmploymentRecord like EmployeeId, CompanyName, and verification code.
   Implement the GetEmployee, get the values by parameter and return the record from list.
   
**EmploymentVerification.Models**
   In this project, Create the required model like
   EmpployeeRecord-> Define the properties, EmployeeId, CompanyName, and verification code
   EmploymentVerificationRequest-> Get the request data from api include, EmployeeId, CompanyName, and verification code
   EmploymentVerificationResponse-> Here IsVerified return true or false in response, and Message for return the desire message like error message, validation or “Verified” or “Not Verified”

**EmploymentVerification.Services**

   In this project, create interface IEmploymentVerificationService and define the VerifyEmployment who return the EmploymentVerificationResponse by getting EmploymentVerificationRequest data.
   EmploymentVerificationService-> Imeplemnt the VerifyEmployment, in which check the employeeid, company name and verification code data passed or not in EmploymentVerificationRequest object, if not display the error message and IsVerified is false.

   // Than Check Verification Code match or not, if not , display the message.
   // If all checks passed than return the Message= Verified and IsVerified=true.

**Use In memory Employment records for testing:**

Employee ID	Company Name	  Verification Code
1	          Test Company A	XYZ-007
2	          Test Company B	XYZ-764
3	          Test Company C	XYZ-432
4	          Test Company D	XYZ-890
5	          Test Company E	XYZ-901
