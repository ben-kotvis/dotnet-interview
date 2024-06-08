using System.Runtime.InteropServices;
using Dotnet.Interview;
using Dotnet.Interview.Model;
using Dotnet.Interview.Model.Exceptions;
using Dotnet.Interview.Test.TestSupport;
using Moq;
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
    public async void TestFour()
    {
        var apiServiceMock = new Mock<IApiService>();
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestFour;
        var company = FirstLevel.ParseCompany(serializedCustomer);
        ICompanyService companyService = CompanyServiceFactory.Create(company, apiServiceMock.Object);
        Assert.Equal(3301, (await companyService.GetSurchargeInCents()));
    }


    // I will pass
    [Fact]
    public async void TestFive()
    {
        var apiServiceMock = new Mock<IApiService>();
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestFive;
        var company = FirstLevel.ParseCompany(serializedCustomer);
        ICompanyService companyService = CompanyServiceFactory.Create(company, apiServiceMock.Object);
        Assert.Equal(1801, (await companyService.GetSurchargeInCents()));
    }

    // 
    [Fact]
    public async void TestSix()
    {        
        var apiServiceMock = new Mock<IApiService>();
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestSix;
        var company = FirstLevel.ParseCompany(serializedCustomer);
        ICompanyService companyService = CompanyServiceFactory.Create(company, apiServiceMock.Object);
        Assert.Equal(1020, (await companyService.GetSurchargeInCents()));
    }




}