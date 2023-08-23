namespace N29_HT2;

public class EmployeeService
{
    private List<string> _emails = new List<string>
    {
        "gitframework@gmail.com",
        "xdsalax57@gmail.com",
        "marmokcsgo004@gmail.com",
    };

    public async Task HireAsync(string firstName, string lastName, string email)
    {
        var emailService = new EmailService();
        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };

        await SendEmailAsync(employee);
        await CreateFile(employee);
        await SendWelcomeOnBoard(employee);
        await SendPoliceOfficeEmail(employee);
    }

    
    private async Task CreateFile(Employee employee)
    {
        string cotractText = GenerateContractText(employee);
        string contractFilename = $"{employee.FirstName} {employee.LastName}'s empliement contract.docx";
        using (StreamWriter writer = new StreamWriter(contractFilename))
        {
            await writer.WriteAsync(cotractText);
        }
    }
    private string GenerateContractText(Employee employee)
    {
        string contractText = $"Employment Contract for {employee.FirstName} {employee.LastName}\n...";
        return contractText;
    }

    private async Task SendWelcomeOnBoard(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = _emails.Select(email => Task.Run(() =>
        {
            var result = emailService.SendAsync(email, "Welcome to G'ishtmat Books",
                $"Dear {employee.FirstName} {employee.LastName}: We are thrilled to welcome you! " +
                $"We are excited to have you on board " +
                $"and look forward to working with you.As a new member of our team, we want to make " +
                $"sure you have everything you need to get started. Please let us " +
                $"know if you have any questions or need any assistance.We wish you all the best in your new role and look forward to " +
                $"your contributions to our team");
            Console.WriteLine($"{email} ga Welcome on board email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }

    private async Task SendPoliceOfficeEmail(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = _emails.Select(email => Task.Run(() =>
        {
            var result = emailService.SendAsync(email, "Office Policies and Guidelines", $"Dear {employee.FirstName} {employee.LastName}: As a member of our team, it is important that " +
                $"you are aware of our office policies and guidelines. " +
                $"These policies are designed to ensure a safe and productive work environment for everyone.Please take a moment to review the attached " +
                $"document, which outlines " +
                $"our policies and guidelines. If you have any questions or concerns, " +
                $"please do not hesitate to reach out to us.Thank you for your cooperation " +
                $"and adherence to our policies.Best regards ");
            Console.WriteLine($"{email} Police email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }


    private async Task SendEmailAsync(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = _emails.Select(emailAddresses => Task.Run(() =>
        {
            var result = emailService.SendAsync(emailAddresses, "Hi,", $"{employee.FirstName} {employee.LastName}: Hii.");
            Console.WriteLine($"{emailAddresses} ga email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }
}