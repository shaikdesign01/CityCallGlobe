using Mobinor.BusinessServices;
using System.Collections.Generic;
using System.Web.Http;
using Mobinor.BusinessObjects;
using Mobinor.BusinessServices.Interfaces;

namespace MobinorWeb.ApiControllers
{
    /// <summary>
    /// Dailers Info Api Controller
    /// </summary>
    public class DailerInfoApiController : ApiController
    {
        /// <summary>
        /// Instance for IDailersInfoService
        /// </summary>
        private readonly IDailersInfoService dailersInfo;

        /// <summary>
        /// DailersInfoService Instance creation
        /// </summary>
        /// <param name="dailersInfo"></param>
        public DailerInfoApiController(IDailersInfoService dailersInfo)
        {
            this.dailersInfo = dailersInfo;
        }

        /// <summary>
        /// Get Countries Function
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetCountries()
        {
            return dailersInfo.GetCountries();
        }

        /// <summary>
        /// Gets Dailers Details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DailersInfo> GetDailerDetails()
        {
            return dailersInfo.GetDailerDetails();
        }

        /// <summary>
        /// Gets Mobile Details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MobileDetail> GetMobileDetails()
        {
            return dailersInfo.GetMobileDetails();
        }

        /// <summary>
        /// Updates the dailer details
        /// </summary>
        /// <param name="dailersData"></param>
        [HttpPost]
        public void UpdateDailerInfo(DailersInfo dailersData)
        {
            dailersInfo.UpdateDailerDetails(dailersData);
        }

        /// <summary>
        /// Delete Dailer Info
        /// </summary>
        /// <param name="dailerId"></param>
        [HttpDelete]
        public void DeleteDailerInfo(int dailerId)
        {
            dailersInfo.DeleteDailerDetails(dailerId);
        }

        /// <summary>
        /// Add Dailers Data
        /// </summary>
        /// <param name="dailersData"></param>
        [HttpPost]
        public void AddDailerInfo(DailersInfo dailersData)
        {
            dailersInfo.SaveDailersDetails(dailersData);
        }
    }
}