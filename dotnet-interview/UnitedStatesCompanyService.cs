using Dotnet.Interview.Model.Exceptions;
using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class UnitedStatesCompanyService : ICompanyService
{
    private Company _company { get; init; }

    public UnitedStatesCompanyService(Company company)
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

    public int GetSurchargeInCents()
    {
        return 431;
    }
}
