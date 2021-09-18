using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3_ConsoleApp1
{
    class Car
    {
        public string CarMake { get; set; }

        public string CarPlate { get; set; }

        public double CarSpeed { get; set; }

        public bool CarStart;
      
        public double CarSpeedUp;

        public double CarSpeedDown;
       
        public bool CarStop;
       
        public string GetCarHorn()
        {
            string CarSetHorn = "Beep Beep!";
            return CarSetHorn;
        }
    }
}
