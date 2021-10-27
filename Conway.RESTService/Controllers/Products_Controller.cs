using Conway.Core.Model;
using Conway.Core.Service;
using Conway.Data;
using Conway.Service.Service;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Conway.RESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products_Controller : ControllerBase
    {
        private readonly AppDbContext _ProductDbContext;
        public Products_Controller(AppDbContext appDbContext)
        {
            _ProductDbContext = appDbContext;
        }

        [HttpGet]
        public  IActionResult GetProducts()
        {
            var products =  _ProductDbContext.Products;
            if (products == null) return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(long id)
        {
            var product = _ProductDbContext.Products.Find(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            var v =  _ProductDbContext.Products;
            var name = v.Select(x => x.Naam == product.Naam).First().ToString();
            if(product.Naam == name) { return Conflict(); }
            var newProduct = _ProductDbContext.Products.AddAsync(product);
            _ProductDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(long id, Product product)
        {
            var v = _ProductDbContext.Products.Find(id);
            if (v == null) { return NotFound("No Product found against this id..."); }
            v.Id = id;
            v.Naam = product.Naam;
            v.Activatie = product.Activatie;
            v.Prijs = product.Prijs;
            v.Inhoud = product.Inhoud;
            v.Fabrikant = product.Fabrikant;
            v.Eancode = product.Eancode;
            v.Diepte = product.Diepte;
            v.Breedte = product.Breedte;
            _ProductDbContext.SaveChanges();
            // 204
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveProduct(long id)
        {
            var product = _ProductDbContext.Products.Find(id);
            if (product == null) { return NotFound("No Product found against this id..."); }
            _ProductDbContext.Products.Remove(product);
            _ProductDbContext.SaveChanges();
            // 204
            return NoContent();
        }
    }
}
