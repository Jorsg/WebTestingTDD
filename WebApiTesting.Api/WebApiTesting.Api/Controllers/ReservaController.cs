using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Core.Models;
using WebApiTesting.Core.Repositories.Interfaces;

namespace WebApiTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReserva _reserva;

        public ReservaController(IReserva reserva)
        {
            _reserva = reserva;
        }

        [HttpGet]
        public async Task<IActionResult> GetReserva()
{
            var result = await _reserva.GetAll();
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReserva(int id)
        {
            var result = await _reserva.GetAll(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostReserva(Reserva reserva)
        {
            var result = await _reserva.CreateReserva(reserva);
            if (result > 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutReserva(Reserva reserva)
        {
            var result = await _reserva.UpdateReserva(reserva);
            if (!result)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReserva(int id)
        {
            var result = await _reserva.DeleteReserva(id);
            if (!result)
                return NotFound();
            return Ok(result);
        }
    }
}
