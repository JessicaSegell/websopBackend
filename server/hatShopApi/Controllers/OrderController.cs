using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors; 
using Microsoft.EntityFrameworkCore;

namespace hatShopApi.Controllers {
    [ApiController]
    [Route("[controller]")]

        public class OrderController : ControllerBase {
        [HttpGet]
        public IEnumerable<Order>GetOrders(){
            using (HatContext context = new HatContext()){
                return context.OrderItems.Include(o => o.CartItems).ToList(); 
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>>GetOrder(int id){
            using (HatContext context = new HatContext()){
                var OneOrder = await context.OrderItems.FirstOrDefaultAsync(o => o.OrderId == id); 
                return OneOrder; 
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            using (HatContext context = new HatContext()){
                CartItem toRemove = context.ShoppingCartItems.First(c => c.Id == id); 
                context.ShoppingCartItems.Remove(toRemove); 
                context.SaveChanges(); 
            }
            return Ok(); 
        }
        [HttpPost]
        public IActionResult Post([FromBody] List<Hat> newCartItem){
            using (HatContext context = new HatContext()){

                Order o = new Order(); 
                context.OrderItems.Add(o); 
                context.SaveChanges(); 

                foreach (var item in newCartItem)
                {
                    CartItem c = new CartItem();
                     c.OrderId = o.OrderId; 
                     c.HatId = item.Id; 
                     c.Quantity = 1; 

                     context.ShoppingCartItems.Add(c); 
                     context.SaveChanges();  
                }
                
            }
            return Created("/order", newCartItem); 
        }
    }
}