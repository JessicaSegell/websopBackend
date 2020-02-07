using System; 
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class CartItem{
    [Key]
    public int Id { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public virtual Order Order {get; set;}
    public int Quantity { get; set; }
    public int HatId { get; set; }
    public virtual Hat Hat { get; set; }
}