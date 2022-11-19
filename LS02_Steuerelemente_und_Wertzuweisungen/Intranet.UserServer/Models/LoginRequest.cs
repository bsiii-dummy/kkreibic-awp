using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Intranet.UserServer.Models;

public class LoginRequest
{
    public long UserId { get; set; }
    public long UserPin { get; set; }
}