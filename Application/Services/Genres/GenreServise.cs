﻿using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Genres
{
    public class GenreServise : IGenreServise
    {
        public Task<Genre> AddGenreAsync(GenreDTO GenreDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> DeleteGenreAsync(long GenreId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Genre>> GetAllGenreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetByIdGenreAsync(long GenreId)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> UpdateGenreAsync(GenreDTO GenreDTO, long GenreId)
        {
            throw new NotImplementedException();
        }
    }
}
