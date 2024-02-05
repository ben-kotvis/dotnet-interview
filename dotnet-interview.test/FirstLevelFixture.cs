using dotnet_interview;

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
    public void Error()
    {        
        var exception = Record.Exception(() => FirstLevel.Divide(10, 0));
        Assert.IsType<DivideByZeroException>(exception);
    }
}