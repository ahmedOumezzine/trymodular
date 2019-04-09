using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using trymodular.Core.Domain.Models;

namespace trymodular.Module.Main.Models {
    public sealed class Role : IdentityRole<Guid>, IEntity<Guid> {
        public Role(string name) {
            Name = name;
        }
    }
}
