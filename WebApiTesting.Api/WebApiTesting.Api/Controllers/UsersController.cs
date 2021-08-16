using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Api.DTO;
using WebApiTesting.Core;
using WebApiTesting.Core.Models;
using WebApiTesting.Core.Repositories;


namespace WebApiTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users ?? throw new ArgumentNullException(nameof(users));
        }

        //// Get api/Users
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var result = _users.GetUsers();
        //    return Ok(result);
        //}

        ////Get api/Users/5
        //[HttpGet("{id: guid}", Name = "user-detail")]
        //public IActionResult GetbyId(Guid id)
        //{
        //    var result = _users.GetbyId(id);
        //    if(result is null)
        //        return NotFound(); 
        //    return Ok(result);
        //}

        //// Pots api/users
        //[HttpPost("{id}")]
        //public IActionResult Post(Guid id, [FromBody] UpserUserDto dto)
        //{
        //    var newUser = _users.Upsert(new Users(Guid.NewGuid(), dto.FullName, dto.Email, dto.Age, dto.Country));
        //    return CreatedAtRoute("user-details", new { id = newUser.Id }, newUser.Id);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Put(Guid id, [FromBody] UpserUserDto dto)
        //{
        //    return Ok(id);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(Guid id)
        //{ 
        //    if(!_users.Remove(id))
        //        return NotFound();
        //    return Ok();
        //}

    }
}
