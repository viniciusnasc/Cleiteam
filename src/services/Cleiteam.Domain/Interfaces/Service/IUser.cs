using System.Security.Claims;

namespace Cleiteam.Domain.Interfaces.Service
{
    public interface IUser
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        bool IsAuthenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetClaimsIdentity();
        string GetBaseUrl();
    }
}