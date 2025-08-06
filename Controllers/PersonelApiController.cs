using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Personel.Data;
using Personel.Models;

namespace Personel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PersonelApiController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _context.personelBilgileris.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddPersonel(PersonelBilgileri p)
        {
            _context.personelBilgileris.Add(p);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePersonel(int id, PersonelBilgileri personel)
        {
            var value = _context.personelBilgileris.Find(id);
            value.Ad = personel.Ad;
            value.Soyad = personel.Soyad;
            value.Sehir = personel.Sehir;
            value.Maas = personel.Maas;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var valu = _context.personelBilgileris.Find(id);
            _context.personelBilgileris.Remove(valu);
            _context.SaveChanges();
            return Ok();
        }
    }
}