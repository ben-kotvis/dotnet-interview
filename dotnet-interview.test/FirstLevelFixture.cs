using System.Runtime.InteropServices;
using Dotnet.Interview;
using Dotnet.Interview.Model;
using Dotnet.Interview.Model.Exceptions;
using Dotnet.Interview.Test.TestSupport;

namespace Dotnet.Interview.test;


/// <summary>
/// Do not change code in this file
/// </summary>
public class FirstLevelFixture
{

    [Fact]
    public void TestOne()
    {
        var eighteen = FirstLevel.IterateAndAddSix(12);
        Assert.Equal(18, eighteen);
    }

    [Fact]
    public void TestTwo()
    {
        var exception = Record.Exception(() => FirstLevel.Divide(10, 0));
        Assert.IsType<ValidationException>(exception);
    }


    [Fact]
    public void TestThree()
    {
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestThree;
        var company = FirstLevel.ParseCompany(serializedCustomer);

        Assert.NotEqual(default(Company), company);
        Assert.Equal("No Symbol", company?.StockSymbol);
    }

    [Fact]
    public void TestFour()
    {
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestFour;
        var company = FirstLevel.ParseCompany(serializedCustomer);
        ICompanyService companyService = CompanyServiceFactory.Create(company);
        Assert.Equal(3301f, companyService.GetSurchargeInCents());
    }


    // I will pass
    [Fact]
    public void TestFive()
    {
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestFive;
        var company = FirstLevel.ParseCompany(serializedCustomer);
        ICompanyService companyService = CompanyServiceFactory.Create(company);
        Assert.Equal(1801, companyService.GetSurchargeInCents());
    }







}