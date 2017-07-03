using System;
using System.Collections.Generic;
using webservice.Infrastructure.Interface.Repository;
using webservice.Infrastructure.Interface.Service;
using webservice.Infrastructure.Model;
using webservice.Infrastructure.ViewModel;

namespace webservice.Infrastructure.Service
{
    public class SalesService : ISalesService
    {
        private readonly IUnitOfWork _uow;

        public SalesService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void RecordSale(RecordSaleViewModel recordSaleViewModel)
        {
            try
            {
                List<Order> customerOrders = new List<Order>();

                foreach (var order in recordSaleViewModel.Orders)
                {
                    var dish = _uow.DishRepository.GetSingle(x => x.Id == order.DishId);
                    customerOrders.Add(new Order {Dish = dish, Quantity = order.Quantity});
                }

                var sale = new Sales
                {
                    Orders = customerOrders,
                    CashReturned = recordSaleViewModel.CashReturned,
                    CashRecieved = recordSaleViewModel.CashRecieved,
                    Amount = recordSaleViewModel.Amount,
                    Date = DateTime.Now
                };

                _uow.SalesRepository.Insert(sale);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}