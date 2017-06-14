using System.Collections.Generic;
using Mobinor.BusinessObjects;
namespace Mobinor.BusinessServices.Interfaces
{
    /// <summary>
    /// Interface for Idailers Info Service
    /// </summary>
    public interface IDailersInfoService
    {
        /// <summary>
        /// Get Countries
        /// </summary>
        /// <returns></returns>
        IEnumerable<Country> GetCountries();

        /// <summary>
        /// Get Dailer Info
        /// </summary>
        /// <returns></returns>
        IEnumerable<DailersInfo> GetDailerDetails();

        /// <summary>
        /// Gets mobile details
        /// </summary>
        /// <returns></returns>
        IEnumerable<MobileDetail> GetMobileDetails();

        /// <summary>
        /// Updated Dailer Info
        /// </summary>
        /// <param name="dailersData"></param>
        /// <returns></returns>
        void UpdateDailerDetails(DailersInfo dailersData);
        /// <summary>
        /// Deletes the dailers info
        /// </summary>
        /// <param name="dailerId"></param>
        void DeleteDailerDetails(int dailerId);
        /// <summary>
        /// Save Dailer Details
        /// </summary>
        /// <param name="dailersData"></param>
        void SaveDailersDetails(DailersInfo dailersData);
   }
}
