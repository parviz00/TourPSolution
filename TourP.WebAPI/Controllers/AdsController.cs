using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.AdsDTO;

namespace TourP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly IAdsService _adsService;

        

        public AdsController(IAdsService adsService)
        {
            _adsService = adsService;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _adsService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result= _adsService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(AdsAddDTO adsAddDTO)
        {
            var result= _adsService.Add(adsAddDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(AdsUpdateDTO adsUpdateDTO)
        {
            var result = _adsService.Update(adsUpdateDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(AdsDeleteDTO adsDeleteDTO)
        {
            var result = _adsService.Delete(adsDeleteDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
