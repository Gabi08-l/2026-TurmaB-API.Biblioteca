using System.ComponentModel.DataAnnotations;

namespace API.Biblioteca.Models
{
    public class Genero
    {
        //o id da classe deve ser o Nome +Id
        public Guid GeneroId { get; set; }

        //nome é obrigatório, ? so pra tirar o cerrilhado
        [Required]
        public string? Nome { get; set; }

        //propriedade de navegação para o relacionamento muitos-para-muitos com Livro
        public ICollection<Livro>? Livros { get; set; }

    }
}
