﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LaptopSystem.App.ViewModels
{
    public class LaptopViewModel
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}