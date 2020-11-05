using fsd16.Models;

namespace fsd16.Resources {
  public class OrderItemResource {
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public virtual Orders Order { get; set; }
    public virtual Products Product { get; set; }

  }
}