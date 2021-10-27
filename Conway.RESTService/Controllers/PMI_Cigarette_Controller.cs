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
    public class PMI_Cigarette_Controller : ControllerBase
    {
        private AppDbContext _PMI_C_DbContext;
        public PMI_Cigarette_Controller(AppDbContext appDbContext)
        {
            _PMI_C_DbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetPMI_C()
        {
            return Ok(_PMI_C_DbContext.PMI_Cigarettes);
        }

        [HttpGet("{id}")]
        public IActionResult GetPMI_C_ById(long id)
        {
            var pmiC = _PMI_C_DbContext.PMI_Cigarettes.Find(id);
            if (pmiC == null) return NotFound();
            return Ok(pmiC);
        }

        [HttpPost]
        public IActionResult Post_PMI_C_DbContext(PMI_Cigarette pmiC)
        {
            var v = _PMI_C_DbContext.PMI_Cigarettes;
            var name = v.Select(x => x.Product == pmiC.Product).First().ToString();
            if (pmiC.Product == name) { return Conflict(); }
            var newPmiC = _PMI_C_DbContext.PMI_Cigarettes.AddAsync(pmiC);
            _PMI_C_DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePMI_C(long id, PMI_Cigarette pmiC)
        {
            var v = _PMI_C_DbContext.PMI_Cigarettes.Find(id);
            if (v == null) { return NotFound("No PMI Cigarettes found against this id..."); }
            v.Id = id;
            v.Product = pmiC.Product;
            v.Color = pmiC.Color;
            v.Eancode = pmiC.Eancode;
            v.Fabrikant = pmiC.Fabrikant;
            v.Groupe = pmiC.Groupe;
            v.Nielsen1 = pmiC.Nielsen1;
            v.Nielsen2 = pmiC.Nielsen2;
            v.Nielsen3 = pmiC.Nielsen3;
            v.Nielsen4 = pmiC.Nielsen4;
            v.Ref = pmiC.Ref;
            v.Size = pmiC.Size;
            _PMI_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemovePMI_C(long id)
        {
            var pmiC = _PMI_C_DbContext.PMI_Cigarettes.Find(id);
            if (pmiC == null) { return NotFound("No PMI Cigarettes found against this id..."); }
            _PMI_C_DbContext.PMI_Cigarettes.Remove(pmiC);
            _PMI_C_DbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
