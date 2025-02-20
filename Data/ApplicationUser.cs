﻿using Microsoft.AspNetCore.Identity;

namespace Blog_App.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name{ get; set; }
        public string? ProfilePicture { get; set; }
    }
}
