
namespace Dotnet.Interview.Model;

public abstract class CompanyAbstractDecorator(ICompanyService companyService) : ICompanyService
{
    //protected ICompanyService _companyService { get; init; } = companyService;
    public virtual string GetStockSymbol()
    {
        return companyService.GetStockSymbol();
    }

    public virtual Task<int> GetSurchargeInCents()
    {
        return companyService.GetSurchargeInCents();
    }
}