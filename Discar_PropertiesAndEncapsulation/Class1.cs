using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discar_PropertiesAndEncapsulation
{
    class Shirt
    {
        //Neo Discar
        //IT301

        //private fields to start brand and color
        private string brand;
        private string size;

        //public property to get/set  the brand
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
       public string Size
        {
            get { return size; }
            set { size = value; }
        }
        //method to display ShirtInfo
        public void DisplayInfo()
        {
            Console.WriteLine("Shirt Brand:" + brand);
            Console.WriteLine("Shirt Size:" + size);
            Console.ReadKey();

        }
    }
}
