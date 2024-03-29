﻿using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.FilmMakers
{
    public interface IFilmMakerServise
    {
        public Task<FilmMaker> AddFilmMakerAsync(FilmMakerDTO FilmMakerDTO);
        public Task<FilmMaker> GetByIdFilmMakerAsync(long FilmMakerId);
        public Task<List<FilmMaker>> GetAllFilmMakerAsync();
        public Task<FilmMaker> UpdateFilmMakerAsync(FilmMakerDTO FilmMakerDTO, long FilmMakerId);
        public Task<FilmMaker> DeleteFilmMakerAsync(long FilmMakerId);
    }
}
