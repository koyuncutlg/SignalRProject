using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
	public class OrderDetialManager : IOrderDetialService
	{
		private readonly IOrderDetialDal _orderDetialDal;

		public OrderDetialManager(IOrderDetialDal orderDetialDal)
		{
			_orderDetialDal = orderDetialDal;
		}

		public void TAdd(OrderDetial entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(OrderDetial entity)
		{
			throw new NotImplementedException();
		}

		public OrderDetial TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<OrderDetial> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(OrderDetial entity)
		{
			throw new NotImplementedException();
		}
	}
}