using ReportBuilder.BLL.Domain;

namespace ReportBuilder.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> ValidateUser(LoginUser loginUser);
        Task<string> CreateToken();
    }
}
