using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class PremiumCompanyService : CompanyAbstractDecorator, ICompanyService
{
    public PremiumCompanyService(ICompanyService companyService)
        :base(companyService)
    {
        
    }

    public string GetStockSymbol()
    {
        return this._companyService.GetStockSymbol();
    }

    public int GetSurchargeInCents()
    {
        return this._companyService.GetSurchargeInCents() + 1500;
    }

}