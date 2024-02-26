using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions.Repositories;
using Domain.Entities;
namespace Infastructure.Repositories
{
    internal class ActorRepository : IActorRepositories
    {
        public Task<Actor> AddActorAsync(Actor Actor)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> DeleteActorAsync(long ActorId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Actor>> GetAllActorAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetByIdActorAsync(long ActorId)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> UpdateActorAsync(Actor Actor, long ActorId)
        {
            throw new NotImplementedException();
        }
    }
}
