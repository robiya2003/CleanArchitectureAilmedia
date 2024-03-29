﻿using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Actors
{
    public interface IActorServise
    {
        public Task<Actor> AddActorAsync(ActorDTO ActorDTO);
        public Task<Actor> GetByIdActorAsync(long ActorId);
        public Task<List<Actor>> GetAllActorAsync();
        public Task<Actor> UpdateActorAsync(ActorDTO ActorDTO, long ActorId);
        public Task<Actor> DeleteActorAsync(long ActorId);
    }
}
