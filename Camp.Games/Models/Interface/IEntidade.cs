namespace Camp.Games.Models.Interface
{
    public interface IEntidade
    {
        int Id { get; set; }
        DateTime DataCadastro { get; set; }
        DateTime DataAlteracao { get; set; }
        DateTime DataEncerramento { get; set; }
    }
}
