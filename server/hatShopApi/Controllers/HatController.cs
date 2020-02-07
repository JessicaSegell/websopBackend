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
    public class HatController : ControllerBase {
        [HttpGet]
        public IEnumerable<Hat>GetHats(){
            using (HatContext context = new HatContext()){
                var hats = context.Hats.Select(h => new Hat() {
                    hatName = h.hatName, 
                    Id = h.Id 
                    
                }); 
                
                return context.Hats.ToList();   
            }    
        }       
        
         [HttpGet("{id}")]
        public async Task<ActionResult<Hat>> GetAHat(int id){
            using (HatContext context = new HatContext()){
                var AHat = await context.Hats.FirstOrDefaultAsync(h => h.Id == id); 
                return AHat;
            }    
        }     
    }
  

}