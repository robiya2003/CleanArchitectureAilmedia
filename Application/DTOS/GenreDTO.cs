﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class GenreDTO
    {
        public string Name { get; set; }
        public List<long> films { get; set; }
    }
}
