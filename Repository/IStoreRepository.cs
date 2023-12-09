using Food.Web.Models;

namespace Food.Web.Repository
{
        public interface IStoreRepository{
            IQueryable<CategoryModel> Categories{get;}
            IQueryable<ProductModel>Products{get;}
        }
}