#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using aspnetapp;

public class Request {
    public string action { get; set; }
}
public class Response {
    public int data { get; set; }
}

namespace aspnetapp.Controllers
{
    [Route("api/auto-reply")]
    [ApiController]
    public class AutoReplyController : ControllerBase
    {

        public AutoReplyController()
        {
            
        }

        // GET: api/count
        [HttpGet]
        public async Task<string> GetReply()
        {
            return "";
        }

        // POST: api/Counter
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostReply() {
            return "dad0";
        }
    }
}
