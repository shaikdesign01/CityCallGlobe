using AutoMapper;
using Mobinor.Repository;
using System.Collections.Generic;

namespace Mobinor.BusinessServices.Common
{
    /// <summary>
    /// Class for EntityMapper
    /// </summary>
    public static class EntityMapper
    {
        /// <summary>
        /// DBContext for MobinorDB
        /// </summary>
        private static MobinorDBEntities DbContext = new MobinorDBEntities();
        /// <summary>
        /// Static Mobinor Mapper
        /// </summary>
        public static readonly IMapper MobinorMapper = new MapperConfiguration(
            cfg => {
                cfg.CreateMap<Country, BusinessObjects.Country>();
                cfg.CreateMap<DailerInfo, BusinessObjects.DailersInfo>();
                cfg.CreateMap<MobileDetail, BusinessObjects.MobileDetail>();
                cfg.CreateMap<BusinessObjects.DailersInfo, Repository.DailerInfo> ();

            }).CreateMapper();
        /// <summary>
        /// Function for ConvertEntityToModel
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IEnumerable<BusinessObjects.Country> ConvertEntityToModel(IEnumerable<Country> data)
        {
            return MobinorMapper.Map<IEnumerable<BusinessObjects.Country>>(data);
        }

        /// <summary>
        /// Converting entity to business objects
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IEnumerable<BusinessObjects.DailersInfo> ConvertEntityToModel(IEnumerable<DailerInfo> data)
        {
            return MobinorMapper.Map<IEnumerable<BusinessObjects.DailersInfo>>(data);
        }

        /// <summary>
        /// Converting entity to business objects for MobileDetails
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IEnumerable<BusinessObjects.MobileDetail> ConvertEntityToModel(IEnumerable<MobileDetail> data)
        {
            return MobinorMapper.Map<IEnumerable<BusinessObjects.MobileDetail>>(data);
        }


        public static Repository.DailerInfo ConvertMModelToEntity(BusinessObjects.DailersInfo data)
        {
            return MobinorMapper.Map<Repository.DailerInfo>(data);
        }
    }
}
