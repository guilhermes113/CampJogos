using Camp.Games.Models.Interface;

namespace Camp.Games.Models
{
    public class Rank  : IEntidade
    {
        public Rank( string nome)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get ; set; }
        public DateTime DataAlteracao { get ; set ; }
        public DateTime DataEncerramento { get; set ; }
        public string Nome { get; set; }
        public void AtualizarDados(string nome)
        {
            Nome = nome;
            DataAlteracao = DateTime.Now;
        }
    }
}
