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
    public class ITB_Cigarette_Controller : ControllerBase
    {
        private AppDbContext _ITB_C_DbContext;
        public ITB_Cigarette_Controller(AppDbContext appDbContext)
        {
            _ITB_C_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetITB_C()
        {
            return Ok(_ITB_C_DbContext.ITB_Cigarettes);
        }

        [HttpGet("{id}")]
        public IActionResult GetITB_C_ById(long id)
        {
            var itbC = _ITB_C_DbContext.ITB_Cigarettes.Find(id);
            if (itbC == null) return NotFound();
            return Ok(itbC);
        }

        [HttpPost]
        public IActionResult Post_ITB_C_DbContext(ITB_Cigarette itbC)
        {
            var v = _ITB_C_DbContext.ITB_Cigarettes;
            var name = v.Select(x => x.Product == itbC.Product).First().ToString();
            if (itbC.Product == name) { return Conflict(); }
            var newItbC = _ITB_C_DbContext.ITB_Cigarettes.AddAsync(itbC);
            _ITB_C_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateITB_C(long id, ITB_Cigarette itbC)
        {
            var v = _ITB_C_DbContext.ITB_Cigarettes.Find(id);
            if (v == null) { return NotFound("No ITB Cigarettes found against this id..."); }
            v.Id = id;
            v.Product = itbC.Product;
            v.Color = itbC.Color;
            v.Eancode = itbC.Eancode;
            v.Fabrikant = itbC.Fabrikant;
            v.Groupe = itbC.Groupe;
            v.Nielsen1 = itbC.Nielsen1;
            v.Nielsen2 = itbC.Nielsen2;
            v.Nielsen3 = itbC.Nielsen3;
            v.Nielsen4 = itbC.Nielsen4;
            v.Ref = itbC.Ref;
            v.Size = itbC.Size;
            _ITB_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveITB_C(long id)
        {
            var itbC = _ITB_C_DbContext.ITB_Cigarettes.Find(id);
            if (itbC == null) { return NotFound("No ITB Cigarettes found against this id..."); }
            _ITB_C_DbContext.ITB_Cigarettes.Remove(itbC);
            _ITB_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
