
namespace Dotnet.Interview.Model;

public abstract class CompanyAbstractDecorator : ICompanyService
{
    protected ICompanyService _companyService { get; init; }
    public CompanyAbstractDecorator(ICompanyService companyService)
    {
        this._companyService = companyService;
    }

    public string GetStockSymbol()
    {
        return _companyService.GetStockSymbol();
    }

    public float GetSurcharge()
    {
        return _companyService.GetSurcharge();
    }
}