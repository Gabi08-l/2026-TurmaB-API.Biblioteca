namespace API.Biblioteca.Models
{
    public class LivroGenero
    {
        public Guid LivroGeneroId { get; set; }
        //fk
        public Guid LivroId { get; set; }
        //propriedades de navegação 

        public Livro? Livro { get; set; }

        //fk
        public Guid GeneroId { get; set; }
        //propriedades de navegação 

        public Genero? Genero { get; set; }

  
    }
}
