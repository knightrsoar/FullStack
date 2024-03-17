using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Service
{
    public interface IRegionServiceAsync
    {
        Task<RegionResponseModel> GetAllRegions();
        Task<int> AddNewRegion(RegionRequestModel r);
        Task<int> GetRegionCountAsync();
        Task<IEnumerable<RegionResponseModel>> GetRegionByName(string name);
        

    }
}
