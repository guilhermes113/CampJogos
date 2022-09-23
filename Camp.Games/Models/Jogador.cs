namespace Camp.Games.Models
{
    public class Jogador : Entidade
    {
        public Jogador(int classificacaoId, string nome, DateTime nascimento, string bio, int rankId, string foto) 
            : base(classificacaoId, nome, nascimento, bio, rankId, foto)
        {
        }
        public List<JogadorTime> JogadoresTimes { get; set; }
    }
}
