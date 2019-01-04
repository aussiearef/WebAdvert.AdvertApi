using System.Collections.Generic;
using System.Threading.Tasks;
using AdvertApi.Models;

namespace AdvertApi.Services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);
        Task<AdvertModel> GetById(string id);
        Task<bool> CheckHealthAsync();
        Task<List<AdvertModel>> GetAll();
    }
}