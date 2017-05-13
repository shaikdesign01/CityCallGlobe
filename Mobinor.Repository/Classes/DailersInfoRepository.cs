using System.Collections.Generic;
using System.Linq;
using Mobinor.Repository.Interfaces;


namespace Mobinor.Repository.Classes
{
    /// <summary>
    /// Dailers Info Repository Class
    /// </summary>
    public class DailersInfoRepository : IDailersInfoRepository
    {
        /// <summary>
        /// DBContext for MobinorDBEntities
        /// </summary>
        private MobinorDBEntities DbContext = new MobinorDBEntities();
        /// <summary>
        /// Method for Get Countries from database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetCountries()
        {
            var countryList = from rel in DbContext.Countries select rel;
            return countryList.ToList();
        }
    }
}
