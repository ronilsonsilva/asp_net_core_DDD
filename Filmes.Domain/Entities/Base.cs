using System;

namespace Filmes.Domain.Entities
{
    public class Base
    {
        public Base(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
