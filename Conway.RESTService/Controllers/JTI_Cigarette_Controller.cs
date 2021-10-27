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
    public class JTI_Cigarette_Controller : ControllerBase
    {
        private AppDbContext _JTI_C_DbContext;
        public JTI_Cigarette_Controller(AppDbContext appDbContext)
        {
            _JTI_C_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetJTI_C()
        {
            return Ok(_JTI_C_DbContext.JTI_Cigarettes);
        }

        [HttpGet("{id}")]
        public IActionResult GetJTI_C_ById(long id)
        {
            var jtiC = _JTI_C_DbContext.JTI_Cigarettes.Find(id);
            if (jtiC == null) return NotFound();
            return Ok(jtiC);
        }

        [HttpPost]
        public IActionResult Post_JTI_C_DbContext(JTI_Cigarette jtiC)
        {
            var v = _JTI_C_DbContext.JTI_Cigarettes;
            var name = v.Select(x => x.Product == jtiC.Product).First().ToString();
            if (jtiC.Product == name) { return Conflict(); }
            var newJtiC = _JTI_C_DbContext.JTI_Cigarettes.AddAsync(jtiC);
            _JTI_C_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJTI_C(long id, JTI_Cigarette jtiC)
        {
            var v = _JTI_C_DbContext.JTI_Cigarettes.Find(id);
            if (v == null) { return NotFound("No JTI Cigarettes found against this id..."); }
            v.Id = id;
            v.Product = jtiC.Product;
            v.Color = jtiC.Color;
            v.Eancode = jtiC.Eancode;
            v.Fabrikant = jtiC.Fabrikant;
            v.Groupe = jtiC.Groupe;
            v.Nielsen1 = jtiC.Nielsen1;
            v.Nielsen2 = jtiC.Nielsen2;
            v.Nielsen3 = jtiC.Nielsen3;
            v.Nielsen4 = jtiC.Nielsen4;
            v.Ref = jtiC.Ref;
            v.Size = jtiC.Size;
            _JTI_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveJTI_C(long id)
        {
            var jtiC = _JTI_C_DbContext.JTI_Cigarettes.Find(id);
            if (jtiC == null) { return NotFound("No JTI Cigarettes found against this id..."); }
            _JTI_C_DbContext.JTI_Cigarettes.Remove(jtiC);
            _JTI_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
