namespace Dotnet.Interview.Model;

public class Contact
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required int Age { get; init; }
    public required PhoneNumber[] PhoneNumbers { get; init; }
    
}
