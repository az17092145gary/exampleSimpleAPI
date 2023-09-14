using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.Common;
using MongoDB.Bson.IO;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using testcallAPI.Models;

namespace testcallAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MemberServices _memberServices;
        public UserController(MemberServices memberServices) {
            _memberServices = memberServices;
        }

        [HttpGet(Name = "GetUserName")]
        public string Get(string name)
        {
            return name + "你好";
        }
        
        [Route("{age}")]
        [HttpGet]
        public string Get(int age)
        {
            return age + "歲";
        }

        [HttpPost]
        [Route("authenticate")]
        [Produces("application/json")]

        public async Task<IActionResult> Post(Member mem)
        {
           await _memberServices.CreateMember(mem);
                return CreatedAtAction(nameof(Get), new { mem });
            
        }

    }

}
