namespace webservice.Infrastructure.Interface.Service
{
    public interface IAccountService
    {
        bool IsUserVerfied(string username, string password);
    }
}