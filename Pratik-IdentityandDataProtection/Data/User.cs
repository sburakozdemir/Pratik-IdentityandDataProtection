﻿using System.ComponentModel.DataAnnotations;

namespace Pratik_IdentityandDataProtection.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
