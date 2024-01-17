using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfOrderDetialDal : GenericRepository<OrderDetial>, IOrderDetialDal
	{
		public EfOrderDetialDal(SignalRContext context) : base(context)
		{
		}
	}
}