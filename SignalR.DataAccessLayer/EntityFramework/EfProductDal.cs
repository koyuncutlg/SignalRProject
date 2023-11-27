using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }
        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}

//var context = new SignalRContext();
//var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
//{
//    Description = y.Description,
//    ImageUrl = y.ImageUrl,
//    Price = y.Price,
//    ProductID = y.ProductID,
//    ProductName = y.ProductName,
//    ProductStatus = y.ProductStatus,
//    CategoryName = y.Category.CategoryName
//});
//return values.ToList();