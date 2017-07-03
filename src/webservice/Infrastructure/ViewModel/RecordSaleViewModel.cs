using System.Collections.Generic;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.ViewModel
{
    public class RecordSaleViewModel
    {
        public decimal Amount { get; set; }

        public decimal CashRecieved { get; set; }

        public decimal CashReturned { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}