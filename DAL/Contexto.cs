using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroSistemas.Models;
//agregamos la liberia del framework
using Microsoft.EntityFrameworkCore;
namespace RegistroSistemas.DAL
{
    //Nuestra clase contexto va a heredar de la clase DBContext Propia de EntityFrameworkCore
    public class Contexto : DbContext
    {
        // creamos el constructor para el contexto 
        public Contexto(DbContextOptions<Contexto> Options) : base(Options) { }
        //Agregamos la tabla de Sistemas  al contexto
        public DbSet<Sistema> Sistemas { get; set; }
    }
}