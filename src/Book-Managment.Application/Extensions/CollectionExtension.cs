using Book_Management.Domain.Commons;
using Book_Management.Domain.Configurations;
using Book_Managment.Application.Exceptions;
using Newtonsoft.Json;

namespace Book_Managment.Application.Extensions
{
    public static class CollectionExtension
    {
        public static IQueryable<T> ToPagedList<T>(this IQueryable<T> sources,
          PaginationParams @params = null) where T : Auditable
        {

            var metaData = new PaginationMetaData(sources.Count(), @params);

            var json = JsonConvert.SerializeObject(metaData);

            return @params.PageIndex > 0 && @params.PageSize > 0 ?
                    sources.OrderByDescending(p => p.CreatedAt)
                    .Skip((@params.PageIndex - 1) * @params.PageSize).Take(@params.PageSize) :
                        throw new CustomException(405, "Please, enter valid numbers");

        }
    }
}
