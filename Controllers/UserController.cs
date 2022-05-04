using BFG.Application.Features.Users;

namespace BFG.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly IMediator _mediator;

    public UsersController(ILogger<UsersController> logger, IMediator mediator)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet("getAll", Name ="GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        _logger.LogInformation("Collecting all users list");
        return Ok(await _mediator.Send(new GetAllUsersQuery()));
    }
}