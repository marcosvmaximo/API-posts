using System;
using System.ComponentModel.DataAnnotations;

namespace Alura_dotnet7.Models
{
	public class Post
	{
        [Key]
        public int Id { get; set; }
		[Required(ErrorMessage = "É necessario um titulo valido")]
		[StringLength(50)]
		public string Titulo { get; set; }
        [Required(ErrorMessage = "É necessario um conteudo valido")]
        [StringLength(500)]
        public string Conteudo { get; set; }
        [StringLength(100)]
        public string? Rodape { get; set; }
        [StringLength(100)]
        public string? Imagem { get; set; }
		public bool PermiteEditar { get; set; }
	}
}

