namespace Bookstore.Models;

public class OrderItem
{
    public Book Book { get; set; } = default!;
    public int Quantity { get; set; }

    public decimal GetTotal() => Book.Price * Quantity;
}