using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Intranet.UserServer.Models;

[PrimaryKey(nameof(UserId))]
public class User
{
    [Key]
    public long UserId { get; set; }

    public string DisplayName { get; set; }
    public int UserPin { get; set; }
    public bool UserActive { get; set; }
    public string UserRole { get; set; }
    public long LoginId { get; set; }
}