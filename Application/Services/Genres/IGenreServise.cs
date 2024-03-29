﻿using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Genres
{
    public interface IGenreServise
    {
        public Task<Genre> AddGenreAsync(GenreDTO GenreDTO);
        public Task<Genre> GetByIdGenreAsync(long GenreId);
        public Task<List<Genre>> GetAllGenreAsync();
        public Task<Genre> UpdateGenreAsync(GenreDTO GenreDTO, long GenreId);
        public Task<Genre> DeleteGenreAsync(long GenreId);
    }
}
