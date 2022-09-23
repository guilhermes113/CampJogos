using Camp.Games.Models.Interface;

namespace Camp.Games.Models
{
    public class Time : IEntidade
    {
        protected Time() { }
        public Time( string nome, string descricao, string imagem, int rankId, Rank rank)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Descricao = descricao;
            Imagem = imagem;
            RankId = rankId;
        }

        
        
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataEncerramento { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        
        public string Imagem { get; set; }
        #region Relacionamentos
        public int RankId { get; set; }
        public Rank Rank { get; set; }
        public int TreinadorId { get; set; }
        public Treinador Treinador { get; set; }
        public List<JogadorTime> JogadoresTimes { get; set; }
        #endregion
        public void AtualizarDados(string nome, string descricao, string imagem, int rankId)
        {
            
            Nome = nome;
            Descricao = descricao;
            Imagem = imagem;
            RankId = rankId;
            DataAlteracao = DateTime.Now;
        }
    }
}
