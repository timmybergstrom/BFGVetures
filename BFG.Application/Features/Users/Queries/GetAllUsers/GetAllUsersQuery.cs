using BFG.Shared.VM;
using BFG.Application.Contracts;

namespace BFG.Application.Features.Users;

public class GetAllUsersQuery : IRequest<List<UsersListAllVM>>
{
  
}

internal class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UsersListAllVM>>
{
    private readonly IUserServices _userServices;
    private readonly IMapper _mapper;
    private List<UsersListAllVM> userList = new();
    public GetAllUsersHandler(IUserServices userServices, IMapper mapper)
    {
        _userServices = userServices;
        _mapper = mapper;
    }

    public async Task<List<UsersListAllVM>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        List<BFGUsers> users = await _userServices.GetAllUsers();
        userList = _mapper.Map(users, userList);
        return userList;
    }
}