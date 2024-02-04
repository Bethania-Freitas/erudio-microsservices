using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }

        public String Name { get; set; }

        public string Price { get; set; }

        public String Description { get; set; }

        public String CategoryName { get; set; }

        public String ImageURL { get; set; }
    }
}
