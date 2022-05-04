using BFG.Application.Contracts;
using BFG.Shared.VM;

namespace BFG.Application.Features.Users;

public class GetUserByIdQuery : IRequest<UserVM>
{
    public int userId { get; set; }
}

internal class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserVM>
{
    private readonly IUserServices _userServices;
    private readonly IMapper _mapper;

    private UserVM userVM = new();

    public GetUserByIdHandler(IUserServices userServices, IMapper mapper)
    {
        _userServices = userServices;
        _mapper = mapper;
    }

    public async Task<UserVM> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {

        return userVM;
    }
}

