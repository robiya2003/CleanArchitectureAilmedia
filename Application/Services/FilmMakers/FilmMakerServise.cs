﻿using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.FilmMakers
{
    public class FilmMakerServise : IFilmMakerServise
    {
        public Task<FilmMaker> AddFilmMakerAsync(FilmMakerDTO FilmMakerDTO)
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> DeleteFilmMakerAsync(long FilmMakerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<FilmMaker>> GetAllFilmMakerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> GetByIdFilmMakerAsync(long FilmMakerId)
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> UpdateFilmMakerAsync(FilmMakerDTO FilmMakerDTO, long FilmMakerId)
        {
            throw new NotImplementedException();
        }
    }
}
