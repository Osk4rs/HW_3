using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3_ConsoleApp1
{
    class Product
    {

        private double _productLenght = 555;
        public double ProductLenght
        {
            get 
            { 
                return _productLenght; 
            }
        }

        private double _productWidth = 756;

        public double ProductWidth
        {
            get
            {
                return _productWidth;
            }
        }

        private double _productDepth = 455;

        public double ProductDepth
        {
            get
            {
                return _productDepth;
            }
        }

        public double ProductWeight { get; set; }


        public bool ProductCreate;

        public string ProductShowData()
        {
            string ProductData = "Product data: Lenght: " + ProductLenght +" Width: "+ ProductWidth +" Depth: "+ ProductDepth +" Weight: "+ ProductWeight;
            return ProductData;
        }
    }
}

