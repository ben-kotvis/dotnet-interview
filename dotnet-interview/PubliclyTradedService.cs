using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class PubliclyTradedService : CompanyAbstractDecorator, ICompanyService
{
    public PubliclyTradedService(ICompanyService companyService)
        :base(companyService)
    {
        
    }

    public string GetStockSymbol()
    {
        return this._companyService.GetStockSymbol();
    }

    public float GetSurcharge()
    {
        return this._companyService.GetSurcharge() + 5.00f;
    }

}