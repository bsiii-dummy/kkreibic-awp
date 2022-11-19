namespace Intranet.UserServer.Models;

public class LoginResponse
{
    public long LoginId { get; set; }
    public string? UserName { get; set; }
    public long UserId { get; set; }
    public bool Success { get; set; }
    public string? Token { get; set; }
}