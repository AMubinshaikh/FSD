using Swagger_2.Models;

namespace Swagger_2.Controllers.Resources {
  public class OrderItemResource {
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public virtual Orders Order { get; set; }
    public virtual Products Product { get; set; }

  }
} 