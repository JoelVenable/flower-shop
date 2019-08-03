using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Tulip : Flower, IStemMeasurable, IDescribable
    {
        public string Color { get; set; }



        public double StemLength { get; set; }


        public string Describe()
        {
            return $"A beautiful {Color} Tulip";
        }
    }
}
