using DataLayer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BusinessLayer.DataTransferModels
{
    public class ProductDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string SerialNo { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ProductCategory Category { get; set; }
    }
}
