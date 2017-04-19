using LifxEmulator.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxEmulator.DataContracts
{
    public class ProductsJson
    {
        [JsonProperty(PropertyName ="vid")]
        public int VendorId { get; set; }
        [JsonProperty(PropertyName ="name")]
        public string VendorName { get; set; }
        [JsonProperty(PropertyName ="products")]
        public List<Product> Products { get; set; }

        private ProductsJson() { }

        public static ProductsJson Populate(Logger mLogger)
        {
            var log = mLogger.CreateChild("Products");
            List<ProductsJson> products = new List<ProductsJson>();

            try
            {
                log.Info("Attempting to read products.json...");
                products = JsonConvert.DeserializeObject<List<ProductsJson>>(
                    File.ReadAllText(@"DataContracts\products.json"));
            }
            catch (Exception ex)
            {
                log.Error("Failed to read products.json", ex.Message);
                products = new List<ProductsJson>();
                products.Add(new ProductsJson());
            }
            return products[0];
        }
    }

    public class Product
    {
        [JsonProperty(PropertyName ="pid")]
        public int ProductId { get; set; }
        [JsonProperty(PropertyName ="name")]
        public string ProductName { get; set; }
        [JsonProperty(PropertyName ="features")]
        public ProductFeature Features { get; set; }
    }

    public class ProductFeature
    {
        [JsonProperty(PropertyName ="color")]
        public bool Color { get; set; }
        [JsonProperty(PropertyName ="infrared")]
        public bool Infrared { get; set; }
        [JsonProperty(PropertyName ="multizone")]
        public bool Multizone { get; set; }
    }
}
