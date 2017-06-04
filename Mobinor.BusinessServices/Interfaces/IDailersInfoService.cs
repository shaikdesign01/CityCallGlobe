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
        IEnumerable<MobileDetail> GetMobileDetails()
;    }
}
