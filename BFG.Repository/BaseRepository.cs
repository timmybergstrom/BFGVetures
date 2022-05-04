namespace BFG.Repository;

public class BaseRepository
{
    private readonly IConfiguration _configuration;
    private readonly BFGdbContext _context;
    public BaseRepository(IConfiguration configuration, BFGdbContext context)
    {
        _configuration = configuration;
        _context = context;
    }
}