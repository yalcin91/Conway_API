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
    public class JTI_Tabac_Controller : ControllerBase
    {
        private AppDbContext _JTI_T_DbContext;
        public JTI_Tabac_Controller(AppDbContext appDbContext)
        {
            _JTI_T_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetJTI_T()
        {
            return Ok(_JTI_T_DbContext.JTI_Tabacs);
        }

        [HttpGet("{id}")]
        public IActionResult GetJTI_T_ById(long id)
        {
            var jtiT = _JTI_T_DbContext.JTI_Tabacs.Find(id);
            if (jtiT == null) return NotFound();
            return Ok(jtiT);
        }

        [HttpPost]
        public IActionResult Post_JTI_T_DbContext(JTI_Tabac jtiT)
        {
            var v = _JTI_T_DbContext.JTI_Tabacs;
            var name = v.Select(x => x.Product == jtiT.Product).First().ToString();
            if (jtiT.Product == name) { return Conflict(); }
            var newJtiT = _JTI_T_DbContext.JTI_Tabacs.AddAsync(jtiT);
            _JTI_T_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJTI_T(long id, JTI_Tabac jtiT)
        {
            var v = _JTI_T_DbContext.JTI_Tabacs.Find(id);
            if (v == null) { return NotFound("No JTI Tabacs found against this id..."); }
            v.Id = id;
            v.Product = jtiT.Product;
            v.Color = jtiT.Color;
            v.Eancode = jtiT.Eancode;
            v.Fabrikant = jtiT.Fabrikant;
            v.Groupe = jtiT.Groupe;
            v.Nielsen1 = jtiT.Nielsen1;
            v.Nielsen2 = jtiT.Nielsen2;
            v.Nielsen3 = jtiT.Nielsen3;
            v.Nielsen4 = jtiT.Nielsen4;
            v.Ref = jtiT.Ref;
            v.Size = jtiT.Size;
            _JTI_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveJTI_T(long id)
        {
            var jtiT = _JTI_T_DbContext.JTI_Tabacs.Find(id);
            if (jtiT == null) { return NotFound("No JTI Tabacs found against this id..."); }
            _JTI_T_DbContext.JTI_Tabacs.Remove(jtiT);
            _JTI_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
