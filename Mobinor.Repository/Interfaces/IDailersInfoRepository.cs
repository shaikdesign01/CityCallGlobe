using System.Collections.Generic;

namespace Mobinor.Repository.Interfaces
{
    /// <summary>
    /// Interface for IDailersInfoRepository
    /// </summary>
    public interface IDailersInfoRepository
    {
        /// <summary>
        /// GetCountries
        /// </summary>
        /// <returns></returns>
        IEnumerable<Country> GetCountries();

        /// <summary>
        /// Get Dailer Info
        /// </summary>
        /// <returns></returns>
        IEnumerable<DailerInfo> GetDailerInfo();

        /// <summary>
        /// Gets Mobile details
        /// </summary>
        /// <returns></returns>
        IEnumerable<MobileDetail> GetMobileDetails();

        /// <summary>
        /// Updates dailer info record
        /// </summary>
        /// <param name="DailerInfo"></param>
        /// <returns></returns>
        void UpdateDailerDetails(DailerInfo dailerInfo);

        /// <summary>
        /// Deletes the dailer info
        /// </summary>
        /// <param name="dailerInfo"></param>
        void DeleteDailerDetails(int dailerId);

        /// <summary>
        /// Save Dailer Details
        /// </summary>
        /// <param name="dailersData"></param>
        void SaveDailersDetails(DailerInfo dailersData);
    }
}
