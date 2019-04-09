using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using trymodular.Core.Domain.Models;

namespace trymodular.Module.Main.Models {
    public class User : IdentityUser<Guid>, IEntity<Guid> {
        public User() {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        public string FullName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
