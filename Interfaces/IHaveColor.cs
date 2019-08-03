using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IHaveColor : IDescribable
    {
        string Color { get; set; }
    }
}
