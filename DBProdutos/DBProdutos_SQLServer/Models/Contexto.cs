using Microsoft.EntityFrameworkCore;

namespace DBProdutos_SQLServer.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }
    }
}
