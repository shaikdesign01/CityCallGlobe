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
    }
}
