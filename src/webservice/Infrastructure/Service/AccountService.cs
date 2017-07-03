using System.Linq;
using webservice.Infrastructure.Interface.Repository;
using webservice.Infrastructure.Interface.Service;

namespace webservice.Infrastructure.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _uow;

        public AccountService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool IsUserVerfied(string username, string password)
        {
            return _uow.UserRepository.Get(x => x.Username == username && x.Password == password).Any();

        }
    }
}