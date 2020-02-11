using System;

namespace Filmes.Domain.Entities
{
    public class Autor : Base
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
