using ListaAfazeres.Model;
using Microsoft.EntityFrameworkCore;

namespace ListaAfazeres.Context;

public class MySQLContext : DbContext
{
    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

    public DbSet<Tarefa> Tarefas { get; set; }
}
