using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IActorRepositories
    {
        public Task<Actor> AddActorAsync(Actor Actor);
        public Task<Actor> GetByIdActorAsync(long ActorId);
        public Task<List<Actor>> GetAllActorAsync();
        public Task<Actor> UpdateActorAsync(Actor Actor, long ActorId);
        public Task<Actor> DeleteActorAsync(long ActorId);
    }
}
