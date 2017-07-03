using System;
using Microsoft.AspNet.Mvc;
using webservice.Infrastructure.Interface.Service;
using webservice.Infrastructure.Model;

namespace webservice.Controllers
{
    public class FoodMenuController : Controller
    {
        private readonly IMenuService _menuService;
        public FoodMenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [Route("api/foodmenu")]
        public object GetAllFoodMenuTypes()
        {
            try
            {
                return new JsonResponse { Data = _menuService.GetAllMenuTypes(), Error = null, Successful = true };
            }
            catch (Exception ex)
            {
                return new JsonResponse { Data = null, Error = ex.Message, Successful = false };
            }

        }
    }
}
