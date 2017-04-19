using LifxEmulator.DataContracts;
using LifxEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxEmulator.Bulbs
{
    public static class BulbFactory
    {
        static Random Gen = new Random();

        public static Bulb CreateBulb(Product bulbData, Logger logger)
        {
            Bulb b;

            if(bulbData.Features.Color)
            {
                b = new ColorBulb(logger);
            }
            else
            {
                b = new Bulb(logger);
            }

            b.ProductName = bulbData.ProductName;
            b.ProductId = bulbData.ProductId;
            b.Label = bulbData.ProductName;
            b.UniqueId = Gen.Next();

            return b;
        }
    }
}
