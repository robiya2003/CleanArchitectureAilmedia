﻿using Application.Abstractions.Repositories;
using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Actors
{
    public class ActorServise : IActorServise
    {
        private readonly IActorRepositories _actorRepositories;
        public ActorServise(IActorRepositories actorRepositories)

        {
            _actorRepositories = actorRepositories;
        }

        public Task<Actor> AddActorAsync(ActorDTO ActorDTO)
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

        public Task<Actor> UpdateActorAsync(ActorDTO ActorDTO, long ActorId)
        {
            throw new NotImplementedException();
        }
    }
}
