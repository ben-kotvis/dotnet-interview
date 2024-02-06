using System.Text.Json;
using System.Text.Json.Serialization;
using dotnet_interview.model;

namespace dotnet_interview;

public class FirstLevel
{
    public static int Divide(int numerator, int denominator)
    {
        return numerator / denominator;
    } 

    public static int IterateAndAddSix(int firstValue)
    {
        var sum = firstValue;
        var query = from s in new int[] {0,2,5,3,6}
                    where s > 5 
                    select sum += s;
        return sum;
    } 

    public static Company? ParseCompany(string json)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        return JsonSerializer.Deserialize<Company>(json, options);
    }
}
