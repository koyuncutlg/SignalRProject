﻿using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        void TChangeStatusToTrue(int id);
        void TChangeStatusToFalse(int id);
    }
}