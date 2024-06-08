using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class PubliclyTradedService(ICompanyService companyService) : CompanyAbstractDecorator(companyService), ICompanyService
{

    public override string GetStockSymbol()
    {
        return this._companyService.GetStockSymbol();
    }

    public override async Task<int> GetSurchargeInCents()
    {
        return (await this._companyService.GetSurchargeInCents()) + 500;
    }

}