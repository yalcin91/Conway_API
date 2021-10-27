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
    public class BAT_Tabac_Controller : ControllerBase
    {
        private AppDbContext _BAT_T_DbContext;
        public BAT_Tabac_Controller(AppDbContext appDbContext)
        {
            _BAT_T_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetBAT_T()
        {
            return Ok(_BAT_T_DbContext.BAT_Tabacs);
        }

        [HttpGet("{id}")]
        public IActionResult GetBAT_T_ById(long id)
        {
            var batT = _BAT_T_DbContext.BAT_Tabacs.Find(id);
            if (batT == null) return NotFound();
            return Ok(batT);
        }

        [HttpPost]
        public IActionResult PostBAT_T(BAT_Tabac batT)
        {
            var v = _BAT_T_DbContext.BAT_Tabacs;
            var name = v.Select(x => x.Product == batT.Product).First().ToString();
            if (batT.Product == name) { return Conflict(); }
            var newBatC = _BAT_T_DbContext.BAT_Tabacs.AddAsync(batT);
            _BAT_T_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBAT_T(long id, BAT_Tabac batT)
        {
            var v = _BAT_T_DbContext.BAT_Tabacs.Find(id);
            if (v == null) { return NotFound("No BAT Tabacs found against this id..."); }
            v.Id = id;
            v.Product = batT.Product;
            v.Color = batT.Color;
            v.Eancode = batT.Eancode;
            v.Fabrikant = batT.Fabrikant;
            v.Groupe = batT.Groupe;
            v.Nielsen1 = batT.Nielsen1;
            v.Nielsen2 = batT.Nielsen2;
            v.Nielsen3 = batT.Nielsen3;
            v.Nielsen4 = batT.Nielsen4;
            v.Ref = batT.Ref;
            v.Size = batT.Size;
            _BAT_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveBAT_T(long id)
        {
            var batT = _BAT_T_DbContext.BAT_Tabacs.Find(id);
            if (batT == null) { return NotFound("No BAT Tabacs found against this id..."); }
            _BAT_T_DbContext.BAT_Tabacs.Remove(batT);
            _BAT_T_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
