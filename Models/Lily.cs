using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{

    public class Lily : Flower, IHaveColor, IDescribable
    {
        public string Color { get; set; }






        public string Describe()
        {
            return $"A beautiful {Color} Lily";
        }
    }
}
