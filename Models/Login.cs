using System;
using System.Collections.Generic;

namespace CustomerManagementSystem_Backend.Models;

public partial class Login
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
