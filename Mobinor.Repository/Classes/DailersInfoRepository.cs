using System.Collections.Generic;
using System.Linq;
using Mobinor.Repository.Interfaces;
using System.Data.Entity;

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
        //private MobinorDBEntities DbContext = new MobinorDBEntities();
        private ccgEntities DbContext = new ccgEntities();


        /// <summary>
        /// Method for Get Countries from database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetCountries()
        {
            var countryList = from rel in DbContext.Countries select rel;
            return countryList.ToList();
        }

        /// <summary>
        /// Gets Dailer Info 
        /// </summary>
        /// <returns>List of dailer details</returns>
        public IEnumerable<DailerInfo> GetDailerInfo()
        {
            var dailerInfoList = from dal in DbContext.DailerInfoes select dal;
            return dailerInfoList.ToList();
        }

        /// <summary>
        /// Gets Mobile Details
        /// </summary>
        /// <returns>List of mobile details</returns>
        public IEnumerable<MobileDetail> GetMobileDetails()
        {
            var mobileInfoList = from dal in DbContext.MobileDetails select dal;
            return mobileInfoList.ToList();
        }

        /// <summary>
        /// Update dailers data
        /// </summary>
        /// <param name="dailerInfo"></param>
        public void UpdateDailerDetails(DailerInfo dailerInfo)
        {
            DbContext.Entry(dailerInfo).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Delete dailers data
        /// </summary>
        /// <param name="dailerId"></param>
        public void DeleteDailerDetails(int dailerId)
        {
            DailerInfo dailerToDelete;
                dailerToDelete = DbContext.DailerInfoes.Where(s => s.Id == dailerId).FirstOrDefault<DailerInfo>();

            DbContext.Entry(dailerToDelete).State = EntityState.Deleted;
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Saves Dailers data
        /// </summary>
        /// <param name="dailersData"></param>
        public void SaveDailersDetails(DailerInfo dailersData)
        {
            DbContext.DailerInfoes.Add(dailersData);
            DbContext.SaveChanges();
        }
    }
}
