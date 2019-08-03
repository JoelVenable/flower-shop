using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop 
{
    public interface IStemMeasurable : IDescribable
    {
        double StemLength { get; set; }
    }
}
