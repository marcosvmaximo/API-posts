using System;
using Alura_dotnet7.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura_dotnet7.Data
{
	public class PostsContext : DbContext
	{
		public PostsContext(DbContextOptions<PostsContext> opt) : base(opt)
		{}

		public DbSet<Post> Posts { get; set; }
	}
}

