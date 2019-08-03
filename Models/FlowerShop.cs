using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class FlowerShop
    {
        public List<Rose> Roses {get; set; }
        public List<Lily> Lilies {get; set; }
        public List<Sunflower> Sunflowers {get; set; }
        public List<Tulip> Tulips {get; set; }



        //  Anything can go in Mothers day as long as it has a stemlength property.  -- rose, tulip, sunflower
        public List<IStemMeasurable> MothersDayArrangement { get; set; } = new List<IStemMeasurable>()
        {
            new Rose() { Price = 4.00, StemLength = 6.44},
            new Sunflower() { Price = 3.00, StemLength = 9.33}
        };

        // Anything in Birthday arrangement needs a color property. -- rose, tulip, lily

    }
        
}
