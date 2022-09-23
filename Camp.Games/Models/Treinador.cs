namespace Camp.Games.Models
{
    public class Treinador : Entidade
    {
        public Treinador(int classificacaoId, string nome, DateTime nascimento, string bio, int rankId, string foto)
            : base(classificacaoId, nome, nascimento, bio, rankId, foto)
        {
        }
        public List<TreinadorTime> TreinadoresTimes { get; set; }
    }
}
