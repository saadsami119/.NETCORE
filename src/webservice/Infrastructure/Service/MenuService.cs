using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using webservice.Infrastructure.Interface.Repository;
using webservice.Infrastructure.Interface.Service;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.Service
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<MenuType> GetAllMenuTypes()
        {
            return _unitOfWork.MenuTypeRepository.Get()
                      .Include(prop => prop.Dishes).ToList();
        }

    }
}
