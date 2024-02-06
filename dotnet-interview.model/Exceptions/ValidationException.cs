namespace Dotnet.Interview.Model.Exceptions;

public class ValidationException : ApplicationException
{
    public ValidationException() :
        base("A validation exception has occurred.")
    {
        
    }
}
