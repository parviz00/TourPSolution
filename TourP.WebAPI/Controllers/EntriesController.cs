using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.EntryDTO;

namespace TourP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesController : ControllerBase
    {
        private readonly IEntryService _entryService;

        public EntriesController(IEntryService entryService)
        {
            _entryService = entryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _entryService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _entryService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(EntryAddDTO entryAddDTO)
        {
            var result = _entryService.Add(entryAddDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(EntryUpdateDTO entryUpdateDTO)
        {
            var result = _entryService.Update(entryUpdateDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(EntryDeleteDTO entryDeleteDTO)
        {
            var result = _entryService.Delete(entryDeleteDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
