using Businese_Layer.Service;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp_web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private SizeService _SizeService;

        public SizeController(SizeService SizeService)
        {
            _SizeService = SizeService;
        }


        [HttpGet("GetSizes")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Size> GetSizes()
        {
            return _SizeService.Getsizes();
        }



        [HttpPost("Addsize")]
        public IActionResult Register([FromBody] Size Size)
        {
            _SizeService.Addsize(Size);
            return Ok("size added successfully!!");
        }

        [HttpDelete("DeleteSize")]

        public IActionResult DeleteSize(int sizeId)  //iactionresult it can return anything like integer string json etc
        {
            _SizeService.Removesize(sizeId);

            return Ok("Size Deleted successfully!!");


        }

        [HttpPut("UpdateSize")]

        public IActionResult UpdateSize([FromBody] Size Size)
        {
            _SizeService.Editsize(Size);
            return Ok("Size updated successfully!!");
        }


        [HttpGet("GetSizebyId")]
        public Size GetSizebyId(int sizeId)
        {

            return _SizeService.GetsizebyId(sizeId);

        }
    }
}
