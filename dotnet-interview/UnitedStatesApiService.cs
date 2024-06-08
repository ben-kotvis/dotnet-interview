using System.Net.Http.Json;
using Dotnet.Interview.Model;
using Dotnet.Interview.Model.Exceptions;

namespace Dotnet.Interview;

public class UnitedStatesApiService : IApiService
{
    private readonly HttpClient _client = new HttpClient();
    public async Task<int> GetSurcharge()
    {
        
        using HttpResponseMessage response = await _client.GetAsync("https://postman-echo.com/get?value=20");
        response.EnsureSuccessStatusCode();
        ApiServiceResponse? responseBody = await response.Content.ReadFromJsonAsync<ApiServiceResponse>();
        if(responseBody == default)
        {
            throw new ValidationException();
        }
        return int.Parse(responseBody.Args.Value);
    }
}