using PruebaTecnica.Entities;

namespace PruebaTecnica.Interfaces;

public interface ISmartphoneService
{
    Task<IEnumerable<SmartphoneEntity>?> GetSmartphonesAsync();
    Task<SmartphoneEntity?> GetSmartphoneByIdAsync(int id);
}

