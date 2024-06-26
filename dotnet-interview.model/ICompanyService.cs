namespace Dotnet.Interview.Model;

public interface ICompanyService
{
    string GetStockSymbol();
    Task<int> GetSurchargeInCents();
}