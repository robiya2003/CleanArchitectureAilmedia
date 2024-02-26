using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class  AudiTable:BaseEntity
    {
        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
