
public class LoginRequest
{
    public LoginRequest(long userId, long userPin)
    {
        UserId = userId;
        UserPin = userPin;
    }
    public long UserId;
    public long UserPin;
}