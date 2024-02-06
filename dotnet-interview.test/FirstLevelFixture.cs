using dotnet_interview;
using dotnet_interview.model;
using dotnet_interview.test.TestSupport;

namespace dotnet_interview.test;


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
        Assert.IsType<DivideByZeroException>(exception);
    }


    [Fact]
    public void TestThree()
    {
        string serializedCustomer = SerializedPayloads.CompanyFixtureOneTestThree;
        var company = FirstLevel.ParseCompany(serializedCustomer);

        Assert.NotEqual(default(Company), company);
        Assert.Equal("ECOW", company?.StockSymbol);
    }
}