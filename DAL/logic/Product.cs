using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.logic
{
    public class Product
    {
        public int ID { get; set; }

        [UseForEqualityCheck]
        public string Code { get; set; }

        public string Name { get; set; }

        public Decimal Price { get; set; }

        public int WarehouseID { get; set; }

        public int CompareTo(object obj)
        {
            return string.Compare(Code, (obj as Product).Code);
        }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
