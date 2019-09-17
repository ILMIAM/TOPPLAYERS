﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOPPLAYERS.Model
{


  
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Shortname { get; set; }
        public string Sex { get; set; }
        public Country Country { get; set; }
        public string Picture { get; set; }
        public Data Data { get; set; }
    }


    public class RootObject
    {
        public List<Player> Players { get; set; }
    }


}
