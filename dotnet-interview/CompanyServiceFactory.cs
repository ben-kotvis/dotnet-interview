using System.Security.Cryptography;
using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class CompanyServiceFactory
{

    public static ICompanyService Create(Company company)
    {
        // Map to country first
        ICompanyService? companyService = company switch 
        {
            { Address.CountryCode: Constants.CountryCodes.UnitedStates } => new UnitedStatesCompanyService(company),
            { Address.CountryCode: Constants.CountryCodes.Canada } => new CanadianCompanyService(company)
        };

        // Map to country first
        companyService = company switch 
        {
            { Type: Constants.CompanyTypes.Simple } => new SimpleService(companyService),
            _ => companyService
        };            
                
        if(company.StockSymbol != default)
        {
            companyService = new PubliclyTradedService(companyService);
        }
        return companyService;
    }
}