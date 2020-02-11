using System;
using Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Infra.Data.Contexto
{
    public class FilmesContext : DbContext
    {
        public static string ConnectionString = @"host=127.0.0.1;port=64402;database=FilmesDB;user id=root;password=Siga2018; providerName=Npgsql";
        public DBSet<Filme> Filmes { get; set; }
        public DBSet<Genero> Generos {get; set; }
        public DBSet<Autor>  Autor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
