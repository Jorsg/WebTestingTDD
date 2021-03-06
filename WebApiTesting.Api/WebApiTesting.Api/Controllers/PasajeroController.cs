using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Core.Repositories.Interfaces;
using WebApiTesting.Core.Models;

namespace WebApiTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasajeroController : ControllerBase
    {
        private readonly IPasajero _pasajero;

        public PasajeroController(IPasajero pasajero)
        {
            _pasajero = pasajero;
        }

        [HttpGet]
        public IActionResult GetPasajero()
        {
            var result = _pasajero.GetAll();
            if(result is null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetPasajero(int id)
        {
            var result = _pasajero.GetAll(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostPasajero(Pasajero traveler)
        {
            var result = _pasajero.InsertPasajero(traveler);
            if (result > 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public IActionResult PutPasajero(Pasajero traveler)
        {
            var result = _pasajero.UpdatePasajero(traveler);
            if (!result)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePasajero(int id)
        {
            var result = _pasajero.DeletePasajero(id);
            if(!result)
                return NotFound();
            return Ok(result);
        }

    }
}
