using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class BlinkerCommandModel
    {
        public bool LeftLed { get; set; }
        public bool RightLed { get; set; }
        public bool Valid { get; set; }
        public string key { get; set; }

    }
}
