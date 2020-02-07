using System; 
using System.Collections.Generic;

public class Order{
    public int OrderId { get; set; }
    public int Total { get; set; }
    public int Quantity { get; set; }
    /* public List<CartItem> cartItems = new List<CartItem>();  */
    public List<CartItem> CartItems {get;set;}
}