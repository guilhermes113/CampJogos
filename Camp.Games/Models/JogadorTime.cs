using System.ComponentModel.DataAnnotations;

namespace Camp.Games.Models
{
    public class JogadorTime
    {
        public JogadorTime(int jogadorId, Jogador jogador, int timeId, Time time)
        {
            JogadorId = jogadorId;
            TimeId = timeId;
        }

        [Key]
        public int JogadorId { get; private set; }
        public Jogador Jogador { get; set; }

        [Key]
        public int TimeId { get; private set; }
        public Time Time { get; set; }
    }
}
