namespace Cleiteam.Domain.Entities
{
    public class TipoOcorrencia : BaseEntity
    {
        public string Descricao { get; set; }

        public List<SubtipoOcorrencia> SubtiposOcorrencia { get; set; }

        public TipoOcorrencia(string descricao)
        {
            Descricao = descricao;
        }

        public TipoOcorrencia(Guid id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            DataEdicao = DateTime.Now;
        }
    }
}