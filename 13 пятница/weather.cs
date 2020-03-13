﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13_пятница
{
    class weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public Bitmap Icon { get  { return new Bitmap(Image.FromFile($"icon/{icon}.png")); } }
    }
}
