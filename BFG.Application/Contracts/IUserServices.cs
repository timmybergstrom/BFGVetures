namespace BFG.Application.Contracts;

public interface IUserServices
{
    Task<List<BFGUsers>> GetAllUsers();
    Task<BFGUsers> GetUserById(Guid Id);
    Task<bool> UserExists(Guid Id);
}