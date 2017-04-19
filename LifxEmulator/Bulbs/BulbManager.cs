using LifxEmulator.DataContracts;
using LifxEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxEmulator.Bulbs
{
    public class BulbManager
    {
        private static BulbManager mInstance = null;

        public List<Bulb> Bulbs { get; private set; }
        private Logger mLogger;

        public static BulbManager GetInstance(Logger log)
        {
            if (mInstance == null)
            {
                mInstance = new BulbManager(log);
            }
            return mInstance;
        }

        private BulbManager(Logger log)
        {
            mLogger = log.CreateChild("BulbManager");
            Bulbs = new List<Bulb>();

            var loadedProductsJson = ProductsJson.Populate(mLogger);
            foreach(var product in loadedProductsJson.Products)
            {
                mLogger.Info("Creating bulb {0}", product.ProductName);
                Bulbs.Add(BulbFactory.CreateBulb(product,mLogger));
            }
        }
    }
}
