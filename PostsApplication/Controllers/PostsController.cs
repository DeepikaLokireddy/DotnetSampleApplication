using Microsoft.AspNetCore.Mvc;
using PostsApplication.Models;

namespace PostsApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {

        private static readonly List<Posts> posts = new()
        {
            new Posts {Id = 1,Title="Commerce",Author = "John"},
            new Posts {Id = 2,Title="History",Author = "Jack"},
        };
        [HttpGet]
        public IActionResult GetPosts()
        {
            
            return Ok(posts);
        }
    }
}
