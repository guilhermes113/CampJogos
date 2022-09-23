using System.ComponentModel.DataAnnotations;

namespace Camp.Games.Models
{
    public class TreinadorTime
    {
        public TreinadorTime(int treinadorId, Treinador treinador, int timeId, Time time)
        {
            TreinadorId = treinadorId;
            TimeId = timeId;
        }

        [Key]
        public int TreinadorId { get; private set; }
        public Treinador Treinador { get; set; }

        [Key]
        public int TimeId { get; private set; }
        public Time Time { get; set; }
    }
}
