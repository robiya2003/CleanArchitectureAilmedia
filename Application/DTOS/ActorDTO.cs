using Domain.Entities.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class ActorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public string photopath { get; set; }
        public List<long> Films { get; set; }
    }
}
