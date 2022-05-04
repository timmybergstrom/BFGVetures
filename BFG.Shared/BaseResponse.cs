namespace BFG.Shared;

public class BaseResponse
{
    private bool Success;
    private string? Message;
    private List<string> ValidationErrors = new();

    public BaseResponse(bool success)
    {
        Success = success;
    }

    public BaseResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}