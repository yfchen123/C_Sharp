using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chapter12
{
    public class Order
    {
        public Order(string CustomerId, int OrderId, int? EmployeeId = null, int? ShipVia = null, decimal? Freight = null) {
            this.CustomerId = CustomerId;
            this.OrderId = OrderId;
            this.EmployeeID = EmployeeId;
            this.ShipVia = ShipVia;
            this.Freight = Freight;
        }
        [RegularExpression("^[A-Z]{5}$", ErrorMessage = "CustomerId must contain exactly five uppercase characters.")]
        public string CustomerId { get; set; }
        public int OrderId { get; set; }
        public int? EmployeeID { get; set; }
        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
    }
}
