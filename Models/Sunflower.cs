using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Sunflower : Flower, IStemMeasurable, IDescribable
    {



        public double StemLength { get; set; }

        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"A beautiful Sunflower with {PetalCount} petals";
        }
    }
}
