using Dotnet.Interview.Model.Exceptions;
using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class CanadianCompanyService : ICompanyService
{
    private Company _company { get; init; }

    public CanadianCompanyService(Company company)
    {
        this._company = company;
    }

    public string GetStockSymbol()
    {
        if (_company.StockSymbol == default)
        {
            throw new ValidationException();
        }
        return _company.StockSymbol;
    }

    public Task<int> GetSurchargeInCents()
    {
        return Task.FromResult(301);
    }
}
