using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpGet("{file}.png")]
        public IActionResult PNGGet(string file)
        {
            string filePath = @"./assets/" + file + ".png";
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                return this.File(bytes, "application/octet-stream");
            }
        }

        [HttpGet("{file}.pdf")]
        public IActionResult PdfGet(string file)
        {
            string filePath = @"./assets/" + file + ".pdf";
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                return this.File(bytes, "application/octet-stream");
            }
        }
    }
}
