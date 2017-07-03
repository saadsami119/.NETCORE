using System.Collections.Generic;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.Interface.Service
{
    public interface IMenuService
    {
        IEnumerable<MenuType> GetAllMenuTypes();
    }
}