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
    }
}
