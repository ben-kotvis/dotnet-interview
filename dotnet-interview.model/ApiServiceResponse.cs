namespace Dotnet.Interview.Model;

public class ApiServiceResponseArgs
{
    public string Value { get; set; }
}

public class ApiServiceResponse
{
    public ApiServiceResponseArgs Args { get; set; }
}