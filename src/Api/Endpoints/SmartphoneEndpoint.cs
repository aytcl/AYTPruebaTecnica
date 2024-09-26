using PruebaTecnica.Entities;
using PruebaTecnica.Interfaces;

namespace PruebaTecnica.Endpoints;
public static class SmartphoneEndpoint {
    /// <summary>
    /// Retorna todos los smartphones
    /// </summary>
    public static async Task<IEnumerable<SmartphoneEntity>?> GetSmartphoneAsync(ISmartphoneService smartphoneService) =>
        await smartphoneService.GetSmartphonesAsync();

    /// <summary>
    /// Retorna un smartphone
    /// </summary>
    public static async Task<SmartphoneEntity?> GetSmartphoneByIdAsync(int id, ISmartphoneService smartphoneService) =>
        await smartphoneService.GetSmartphoneByIdAsync(id);

    public static void MapSmartphoneEndpoint(this WebApplication app) {
        var SmartphoneApi = app.NewVersionedApi();
        var v1 = SmartphoneApi.MapGroup( "/v{version:apiVersion}" ).HasApiVersion(1.0);

        app.MapGet("/smartphone", GetSmartphoneAsync);
        app.MapGet("/smartphone/{id}", GetSmartphoneByIdAsync);
    }
}