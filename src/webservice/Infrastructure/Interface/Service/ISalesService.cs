using webservice.Infrastructure.ViewModel;

namespace webservice.Infrastructure.Interface.Service
{
    public interface ISalesService
    {
        void RecordSale(RecordSaleViewModel recordSaleViewModel);
    }
}