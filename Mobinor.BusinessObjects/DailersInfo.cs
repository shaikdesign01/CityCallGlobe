using System;

namespace Mobinor.BusinessObjects
{ 
    /// <summary>
    /// DailersInfo Class
    /// </summary>
    public class DailersInfo
    {

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or Sets MobileId
        /// </summary>
        public Nullable<int> MobileId { get; set; }
        /// <summary>
        /// Gets or Sets DailerName
        /// </summary>
        public string DailerName { get; set; }
        /// <summary>
        /// Gets or Set DailerLink
        /// </summary>
        public string DailerLink { get; set; }
        /// <summary>
        /// Gets or Set OperatorCode
        /// </summary>
        public string OperatorCode { get; set; }
        /// <summary>
        /// Gets or Set CountryId
        /// </summary>
        public Nullable<int> CountryId { get; set; }
    }
}
