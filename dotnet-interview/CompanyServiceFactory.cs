using Dotnet.Interview.Model;

namespace Dotnet.Interview;

public class CompanyServiceFactory
{
    public static ICompanyService Create(Company company)
    {
        // Map to country first
        ICompanyService? companyService = default;

        switch(company.Address.CountryCode)
        {
            case Constants.CountryCodes.Canada:
                companyService = new CanadianCompanyService(company);
                break;

            default:
                companyService = new CanadianCompanyService(company);
                break;
        }
                    
        companyService = new CanadianSimpleService(companyService);

        switch(company.Type)
        {
            case Constants.CompanyTypes.Simple:
                default:
                    //this is the default so do nothing
                break;
        }
        return companyService;
    }
}