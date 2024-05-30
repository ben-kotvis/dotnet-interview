using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class CompanyServiceFactory
{

    public static ICompanyService Create(Company company)
    {
        // Map to country first
        ICompanyService? companyService = company switch 
        {
            { Address.CountryCode: Constants.CountryCodes.Canada } => new CanadianCompanyService(company),
            _ => new CanadianCompanyService(company)
        };
                    
        companyService = new CanadianSimpleService(companyService);
        // add decorators
        companyService = company switch
        {
            { Type: Constants.CompanyTypes.Premium} => new PremiumCompanyService(companyService),
            _ => companyService
        };

        if(company.StockSymbol != default)
        {
            companyService = new PubliclyTradedService(companyService);
        }
        return companyService;
    }
}