using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3_ConsoleApp1
{
    class Phone
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public int Call;

        public string Sms;

        public string PhoneShowData()
        {
            string PhoneData = "Phone: " + Manufacturer + " Model: " + Model + " Dimensions: " + Height + "H x " + Width + "W x " + Depth + "D";
            return PhoneData;
        }

    }
}
