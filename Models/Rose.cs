using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Rose : Flower, IStemMeasurable, IHaveColor, IDescribable
    {
        public string Color { get; set; }

        public bool HasThorns { get; set; }



        public double StemLength { get; set; }

        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Rose";
        }
    }
}
