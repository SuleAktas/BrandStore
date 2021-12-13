﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrandStore.Models
{
    public class MainCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        [NotMapped]
        public IFormFile PhotoFile { get; set; }

        public bool Active { get; set; }
    }
}
