using System;
using Alura_dotnet7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alura_dotnet7.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PostsBlogController : ControllerBase
	{
		private readonly List<Post> Posts = new List<Post>();

		[HttpPost]
		public void AdicionarPost([FromBody]Post post)
		{
			Posts.Add(post);
		}

		[HttpGet]
		public IEnumerable<Post> ObterPosts()
		{
			return Posts;
		}

		[HttpGet("{id}")]
		public IActionResult ObterPostPorId(int id)
		{
			var post = Posts.FirstOrDefault(post => post.Id == id);
            return post != null ? Ok(post) : BadRequest();
		}
	}
}

