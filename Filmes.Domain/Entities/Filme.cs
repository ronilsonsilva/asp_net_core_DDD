using System;
using System.Collections.Generic;

namespace Filmes.Domain.Entities
{
    public class Filme : Base
    {
        public String Nome { get; set; }     
        public DateTime AnoLancamento { get; set; }
        public String Introducao { get; set; }
        public ICollection<Autor> Autores { get; set; }
        public IColletion<Genero> Genero { get; set; }
    }
}
