using Microsoft.EntityFrameworkCore;
using EletronicoAPI.Models;

namespace EletronicoAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options) { }
        public DbSet<EletronicoAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<EletronicoAPI.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<EletronicoAPI.Models.Produto> Produto { get; set; } = default!;
        public DbSet<EletronicoAPI.Models.Venda> Venda { get; set; } = default!;
    }
}
