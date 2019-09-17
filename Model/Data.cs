using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOPPLAYERS.Model
{
    public class Data
    {
        public int Rank { get; set; }
        public int Points { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public List<int> Last { get; set; }
    }
}
