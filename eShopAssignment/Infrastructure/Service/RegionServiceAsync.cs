using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Service;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
namespace Infrastructure.Service
{
    public class RegionServiceAsync : IRegionServiceAsync
    {

        public readonly IRegionRepositoryAsync _regionRepositoryAsync;
        public RegionServiceAsync(IRegionRepositoryAsync regionRepositoryAsync)
        {
            _regionRepositoryAsync = regionRepositoryAsync;
        }


        public Task<int> AddNewRegion(RegionRequestModel r)
        {
            Region region = new Region() { 
            Name=r.Name
            };
           return _regionRepositoryAsync.InsertAsync(region);
        }

        public Task<RegionResponseModel> GetAllRegions()
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<RegionResponseModel>> GetRegionByName(string name)
        {
          var result= await _regionRepositoryAsync.Filter(x => x.Name == name);
            List<RegionResponseModel> lst = new List<RegionResponseModel>();
            foreach (Region r in result)
            {
                RegionResponseModel m = new RegionResponseModel();
                m.Id = r.Id;
                m.Name = r.Name;
                lst.Add(m);
            }
            return lst;
        }

        public async Task<int> GetRegionCountAsync()
        {
            var allregion = await _regionRepositoryAsync.GetAllAsync();
            return allregion.Count();
        }
    }
}
