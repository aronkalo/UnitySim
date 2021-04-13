using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UnitySim.Server.Controllers
{
    [ApiController]
    [Route("api/upload/images")]
    public class DepthController : ControllerBase
    {
        [HttpPost]
        [Route("stereo_map")]
        public async Task<string> PostStereoImagePairs()
        {
            throw new NotImplementedException();
        }
    }
}
