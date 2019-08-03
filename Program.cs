using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop myShop = new FlowerShop();

            myShop.MothersDayArrangement.ForEach(arr =>
            {
                arr.Describe();
            });
        }
    }
}
