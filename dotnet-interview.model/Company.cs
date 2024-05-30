namespace Dotnet.Interview.Model;

public class Company
{
    public required string Name { get; init; }
    public string? StockSymbol { get; init; } = "No Symbol";
    public required string Type { get; init; }
    public required Contact[] Contacts { get; init; }
    public required Address Address { get; init; }
    
}
