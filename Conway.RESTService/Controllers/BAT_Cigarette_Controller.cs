using Conway.Core.Model;
using Conway.Data;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conway.RESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BAT_Cigarette_Controller : ControllerBase
    {
        private AppDbContext _BAT_C_DbContext;
        public BAT_Cigarette_Controller(AppDbContext appDbContext)
        {
            _BAT_C_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetBAT_C()
        {
            return Ok(_BAT_C_DbContext.BAT_Cigarettes);
        }

        [HttpGet("{id}")]
        public IActionResult GetBAT_C_ById(long id)
        {
            var batC = _BAT_C_DbContext.BAT_Cigarettes.Find(id);
            if (batC == null) return NotFound();
            return Ok(batC);
        }

        [HttpPost]
        public IActionResult Post_BAT_C_DbContext(BAT_Cigarette batC)
        {
            var v = _BAT_C_DbContext.BAT_Cigarettes;
            var name = v.Select(x => x.Product == batC.Product).First().ToString();
            if (batC.Product == name) { return Conflict(); }
            var newBatC = _BAT_C_DbContext.BAT_Cigarettes.AddAsync(batC);
            _BAT_C_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBAT_C(long id, BAT_Cigarette batC)
        {
            var v = _BAT_C_DbContext.BAT_Cigarettes.Find(id);
            if (v == null) { return NotFound("No BAT Cigarettes found against this id..."); }
            v.Id = id;
            v.Product = batC.Product;
            v.Color = batC.Color;
            v.Eancode = batC.Eancode;
            v.Fabrikant = batC.Fabrikant;
            v.Groupe = batC.Groupe;
            v.Nielsen1 = batC.Nielsen1;
            v.Nielsen2 = batC.Nielsen2;
            v.Nielsen3 = batC.Nielsen3;
            v.Nielsen4 = batC.Nielsen4;
            v.Ref = batC.Ref;
            v.Size = batC.Size;
            _BAT_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveBAT_C(long id)
        {
            var batc = _BAT_C_DbContext.BAT_Cigarettes.Find(id);
            if (batc == null) { return NotFound("No BAT Cigarettes found against this id..."); }
            _BAT_C_DbContext.BAT_Cigarettes.Remove(batc);
            _BAT_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
