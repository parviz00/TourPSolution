using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.StepsDTO;

namespace TourP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepsController : ControllerBase
    {
        private readonly IStepService _stepService;

        public StepsController(IStepService stepService)
        {
            _stepService = stepService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _stepService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _stepService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(StepsAddDTO stepsAddDTO)
        {
            var result = _stepService.Add(stepsAddDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(StepsUpdateDTO stepsUpdateDTO)
        {
            var result = _stepService.Update(stepsUpdateDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(StepsDeleteDTO stepsDeleteDTO)
        {
            var result = _stepService.Delete(stepsDeleteDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
