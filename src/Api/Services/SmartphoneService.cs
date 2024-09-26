using PruebaTecnica.Entities;
using PruebaTecnica.Interfaces;

namespace PruebaTecnica.Services;

public class SmartphoneService() : ISmartphoneService
{
    private readonly HttpClient _client = new();
    public async Task<IEnumerable<SmartphoneEntity>?> GetSmartphonesAsync()
    {
        var result = Enumerable.Empty<SmartphoneEntity>();
        HttpResponseMessage response = await _client.GetAsync(requestUri: "https://api.restful-api.dev/objects");
        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadFromJsonAsync<IEnumerable<SmartphoneEntity>?>();
        }
        return result;
    }

    public async Task<SmartphoneEntity?> GetSmartphoneByIdAsync(int id)
    {
        SmartphoneEntity? result = new();
        HttpResponseMessage response = await _client.GetAsync(requestUri: $"https://api.restful-api.dev/objects/{id}");
        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadFromJsonAsync<SmartphoneEntity?>();
        }
        return result;
    }
}