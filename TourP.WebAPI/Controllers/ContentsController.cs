using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.ContentDTO;

namespace TourP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentsController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _contentService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _contentService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(ContentAddDTO contentAddDTO)
        {
            var result = _contentService.Add(contentAddDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(ContentUpdateDTO contentUpdateDTO)
        {
            var result = _contentService.Update(contentUpdateDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(ContentDeleteDTO contentDeleteDTO)
        {
            var result = _contentService.Delete(contentDeleteDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
