using Microsoft.AspNetCore.Mvc;
using MyFisrtApi.Models;

namespace MyFisrtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Post>> GetPosts()
        {
            return new List<Post>
            {
                new() { Id = 1, UserId = 1, Title = "Post 1", Body = "This is the body of post 1" },
                new() { Id = 2, UserId = 2, Title = "Post 2", Body = "This is the body of post 2" }
            };
        }
    }
}