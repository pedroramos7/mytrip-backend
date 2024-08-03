using Microsoft.AspNetCore.Identity;
using System;

namespace UserService.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid TenantId { get; set; }  // Tenant Identifier
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
