using Camp.Games.Models.Interface;

namespace Camp.Games.Models
{
    public abstract class Entidade : IEntidade
    {
        protected Entidade(int classificacaoId, string nome, DateTime nascimento, string bio, int rankId, string foto)
        {
            ClassificacaoId = classificacaoId;
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Nascimento = nascimento;
            Bio = bio;
            RankId = rankId;
            Foto = foto;
        }

        public int Id { get ; set ; }
        public DateTime DataCadastro { get ; set ; }
        public DateTime DataAlteracao { get ; set ; }
        public DateTime DataEncerramento { get ; set ; }
        public string  Nome { get; set ; }
        public DateTime  Nascimento { get ; set ; }
        public string Bio { get; set ; }
        
        
        public string Foto { get; set ; }
        public int ClassificacaoId { get; set; }
        public Classificacao Classificacao { get; set; }
        public int RankId { get; set; }
        public Rank Rank { get; set; }

        public void AtualizarDados(int classificacaoId, string nome, DateTime nascimento, string bio, int rankId, string foto)
        {
            ClassificacaoId = classificacaoId;
            Nome = nome;
            Nascimento = nascimento;
            Bio = bio;
            RankId = rankId;
            Foto = foto;
            DataAlteracao = DateTime.Now;
        }
    }
}
