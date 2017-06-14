using System.Collections.Generic;
using System.Linq;
using Mobinor.BusinessObjects;
using Mobinor.BusinessServices.Interfaces;
using Mobinor.Repository.Interfaces;
using System.Threading.Tasks;
using Mobinor.BusinessServices.Common;
using System;

namespace Mobinor.BusinessServices
{
    /// <summary>
    /// Class for DailersInfoService
    /// </summary>
    public class DailersInfoService : IDailersInfoService
    {
        /// <summary>
        /// Private variable for IdailersInfoRepository
        /// </summary>
        private readonly IDailersInfoRepository dailerInfoRepo;
        /// <summary>
        /// Constructor for DailersInfoService, Injecting Dependency
        /// </summary>
        /// <param name="dailerInfoRepo"></param>
        public DailersInfoService(IDailersInfoRepository dailerInfoRepo)
        {
            this.dailerInfoRepo = dailerInfoRepo;
        }
        /// <summary>
        /// Get Countries method
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetCountries()
        {
            IEnumerable<Repository.Country> countryEntities = this.dailerInfoRepo.GetCountries();
            IEnumerable<BusinessObjects.Country> data = EntityMapper.ConvertEntityToModel(countryEntities);
            return data;
        }

        /// <summary>
        /// Get Dailers Details
        /// </summary>
        /// <returns>List of dailer details</returns>
        public IEnumerable<DailersInfo> GetDailerDetails()
        {
            IEnumerable<Repository.DailerInfo> dailerEntities = this.dailerInfoRepo.GetDailerInfo();
            IEnumerable<BusinessObjects.DailersInfo> data = EntityMapper.ConvertEntityToModel(dailerEntities);
            return data;
        }

        /// <summary>
        /// Gets Mobile details
        /// </summary>
        /// <returns>List of mobile details</returns>
        public IEnumerable<MobileDetail> GetMobileDetails()
        {
            try
            {
                IEnumerable<Repository.MobileDetail> mobileEntities = this.dailerInfoRepo.GetMobileDetails();
                IEnumerable<BusinessObjects.MobileDetail> data = EntityMapper.ConvertEntityToModel(mobileEntities);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Updates Dailer Info
        /// </summary>
        /// <param name="dailersData"></param>
        /// <returns></returns>
        public void UpdateDailerDetails(DailersInfo dailersData)
        {
            Repository.DailerInfo data = EntityMapper.ConvertMModelToEntity(dailersData);
             this.dailerInfoRepo.UpdateDailerDetails(data);
        }

        public void DeleteDailerDetails(int dailerId)
        {
            this.dailerInfoRepo.DeleteDailerDetails(dailerId);
        }

        /// <summary>
        /// Save Dailer Details
        /// </summary>
        /// <param name="dailersData"></param>
        public void SaveDailersDetails(DailersInfo dailersData)
        {
            Repository.DailerInfo data = EntityMapper.ConvertMModelToEntity(dailersData);
            this.dailerInfoRepo.SaveDailersDetails(data);
        }
    }
}
