using System;
using System.Collections.Generic;
using webservice.Infrastructure.Interface;

namespace webservice.Infrastructure.Model
{
    public class Sales : IEntity
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public  decimal CashRecieved { get; set; }

        public decimal CashReturned { get; set; }

        public  DateTime Date { get; set; }

        public List<Order> Orders { get; set; } 
    }
}