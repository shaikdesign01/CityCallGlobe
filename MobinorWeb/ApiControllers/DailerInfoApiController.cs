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
    }
}