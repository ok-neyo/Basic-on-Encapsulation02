using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Discar_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Neo Discar
            //IT301
            
            //Instantiate a new Shirt Obj
            Shirt shirt1= new Shirt();

            //set Shirt Bran
            shirt1.Brand = "UA";
            //set shirt size
            shirt1.Size = "Large";
            //Display shirt info
            shirt1.DisplayInfo();


        }
    }
}
