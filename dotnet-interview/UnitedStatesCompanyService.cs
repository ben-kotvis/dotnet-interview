using Dotnet.Interview.Model.Exceptions;
using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class UnitedStatesCompanyService(Company company) : ICompanyService
{
    private Company Company { get; init; } = company;
    private IApiService ApiService { get; init; } = new UnitedStatesApiService();

    public string GetStockSymbol()
    {
        if (Company.StockSymbol == default)
        {
            throw new ValidationException();
        }
        return Company.StockSymbol;
    }

    public async Task<int> GetSurchargeInCents()
    {
        return await ApiService.GetSurcharge();
    }
}
