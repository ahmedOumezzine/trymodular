using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trymodular.Core.Domain.Models
{
    public interface IEntity<out TId>
    {
       TId Id { get; }
    }
}
