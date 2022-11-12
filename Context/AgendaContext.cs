using Microsoft.EntityFrameworkCore;
using ModeloApi.Models;

namespace ModeloApi.Context
{

    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }

}