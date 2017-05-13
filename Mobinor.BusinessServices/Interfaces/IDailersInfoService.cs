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
    }
}
