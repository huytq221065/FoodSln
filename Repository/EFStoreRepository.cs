using Food.Web.Models;

namespace Food.Web.Repository
{
public class EFStoreRepository:IStoreRepository
{
    private DataContext context;
    public EFStoreRepository(DataContext ctx)
    {
        context=ctx;
    }
    public IQueryable<ProductModel>Products=>context.Products;
    public IQueryable<CategoryModel>Categories=>context.Categories;
}
}