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
    }
}
