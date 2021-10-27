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
    public class ITB_Tabac_Controller : ControllerBase
    {
        private AppDbContext _ITB_T_DbContext;
        public ITB_Tabac_Controller(AppDbContext appDbContext)
        {
            _ITB_T_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetITB_T()
        {
            return Ok(_ITB_T_DbContext.ITB_Tabacs);
        }

        [HttpGet("{id}")]
        public IActionResult GetITB_T_ById(long id)
        {
            var itbT = _ITB_T_DbContext.ITB_Tabacs.Find(id);
            if (itbT == null) return NotFound();
            return Ok(itbT);
        }

        [HttpPost]
        public IActionResult Post_ITB_T_DbContext(ITB_Tabac itbT)
        {
            var v = _ITB_T_DbContext.ITB_Tabacs;
            var name = v.Select(x => x.Product == itbT.Product).First().ToString();
            if (itbT.Product == name) { return Conflict(); }
            var newItbT = _ITB_T_DbContext.ITB_Tabacs.AddAsync(itbT);
            _ITB_T_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateITB_T(long id, ITB_Tabac itbT)
        {
            var v = _ITB_T_DbContext.ITB_Tabacs.Find(id);
            if (v == null) { return NotFound("No ITB Tabacs found against this id..."); }
            v.Id = id;
            v.Product = itbT.Product;
            v.Color = itbT.Color;
            v.Eancode = itbT.Eancode;
            v.Fabrikant = itbT.Fabrikant;
            v.Groupe = itbT.Groupe;
            v.Nielsen1 = itbT.Nielsen1;
            v.Nielsen2 = itbT.Nielsen2;
            v.Nielsen3 = itbT.Nielsen3;
            v.Nielsen4 = itbT.Nielsen4;
            v.Ref = itbT.Ref;
            v.Size = itbT.Size;
            _ITB_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveITB_T(long id)
        {
            var itbT = _ITB_T_DbContext.ITB_Tabacs.Find(id);
            if (itbT == null) { return NotFound("No ITB Tabacs found against this id..."); }
            _ITB_T_DbContext.ITB_Tabacs.Remove(itbT);
            _ITB_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
