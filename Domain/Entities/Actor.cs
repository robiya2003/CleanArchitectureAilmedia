using Domain.Common;
using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Actor:AudiTable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description {  get; set; }
        public Gender Gender { get; set; }
        
        public List<Film> Films { get; set; }
    }
}
