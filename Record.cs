﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_the_world
{
    internal class Record
    {
        public int points { get; set; }
        public DateTime date { get; set; }

        public Record (int points, DateTime date) { 
            this.points = points;
            this.date = date;
        }



    }
}
