﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDesign.Models
{
    public class APIContext: DbContext {
        public APIContext(DbContextOptions<APIContext> options): base(options) { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
