using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<About>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {

        }
        public void Add(Basket entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Basket entity)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(x => x.MenuTableID == id).Include(y=>y.Product).ToList();
            return values;
        }

        public void Update(Basket entity)
        {
            throw new NotImplementedException();
        }

        Basket IGenericDal<Basket>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Basket> IGenericDal<Basket>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}