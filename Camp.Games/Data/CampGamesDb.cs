using Camp.Games.Models;
using Microsoft.EntityFrameworkCore;

namespace Camp.Games.Data
{
    public class CampGamesDb : DbContext
    {
        public CampGamesDb(DbContextOptions<CampGamesDb> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogadorTime>().HasKey(jt => new
            {
                jt.JogadorId,
                jt.TimeId
            });

            modelBuilder.Entity<TreinadorTime>().HasKey(tt => new
            {
               tt.TreinadorId, tt.TimeId
            });
        }

        public DbSet<Jogador> Jogadores  { get; set; }
        public DbSet<Treinador> Treinadores  { get; set; }
        public DbSet<Espectador> Espectadores  { get; set; }
        public DbSet<Time> Times  { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Classificacao> Classificacoes { get; set; }
        public DbSet<JogadorTime> JogadoresTimes  { get; set; }
        public DbSet<TreinadorTime> TreinadoresTimes { get; set; }
    }
}
