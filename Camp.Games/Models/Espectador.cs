using Camp.Games.Models.Interface;
using System.Net.NetworkInformation;

namespace Camp.Games.Models
{
    public class Espectador : IEntidade
    {
        public Espectador(string nome, string bio, string foto,int classificacaoId)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Bio = bio;
            Foto = foto;
            ClassificacaoId = classificacaoId;
        }

        public int Id { get ; set ; }
        public DateTime DataCadastro { get ; set ; }
        public DateTime DataAlteracao { get ; set ; }
        public DateTime DataEncerramento { get ; set ; }
        public string Nome { get ; set ; }
        public string Bio { get ; set ; }
        public string Foto { get ; set ; }
        public int ClassificacaoId { get; set; }
        public Classificacao Classificacao { get; set; }
        public void AtualizarDados(string nome, string bio, string foto, int classificacaoId)
        {
            
            Nome = nome;
            Bio = bio;
            Foto = foto;
            ClassificacaoId = classificacaoId;
            DataAlteracao = DateTime.Now;
            
        }
    }
}
