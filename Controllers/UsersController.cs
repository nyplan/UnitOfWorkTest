using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.BLL.Abstract;
using UnitOfWork.DTOs.UserDTOs;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }
        [HttpPost]
        public IActionResult Post(UserToAddDto dto)
        {
            _service.Add(dto);
            return Ok(dto);
        }
        [HttpPut]
        public IActionResult Put(UserToUpdateDto dto)
        {
            _service.Update(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
