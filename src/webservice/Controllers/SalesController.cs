using System;
using Microsoft.AspNet.Mvc;
using webservice.Infrastructure.Interface.Service;
using webservice.Infrastructure.Model;
using webservice.Infrastructure.ViewModel;

namespace webservice.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        } 

        [Route("api/sales")]
        [HttpPost]
        public JsonResponse RecordSales([FromBody]RecordSaleViewModel viewModel)
        {
            try
            {
                _salesService.RecordSale(viewModel);
                return new JsonResponse { Data = "Sales record inserted sucsessfully!", Error = null, Successful = true };
            }
            catch (Exception ex)
            {
                return new JsonResponse {Data = null, Error = ex.Message, Successful = false};
            }
        }
    }
    
}