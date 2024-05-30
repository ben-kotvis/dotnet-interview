using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class CanadianSimpleService : CompanyAbstractDecorator, ICompanyService
{
    public CanadianSimpleService(ICompanyService companyService)
        :base(companyService)
    {
        
    }

    public string GetStockSymbol()
    {
        return this._companyService.GetStockSymbol();
    }

    public int GetSurchargeInCents()
    {
        return this._companyService.GetSurchargeInCents() + 1000;
    }

}