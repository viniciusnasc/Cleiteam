namespace Cleiteam.Domain.Entities
{
    public class SubtipoOcorrencia : BaseEntity
    {
        public string Descricao { get; set; }
        public Guid IdTipoOcorrencia { get; set; }

        public TipoOcorrencia TipoOcorrencia { get; set; }
        public List<Ocorrencia> Ocorrencias { get; set; }

        public SubtipoOcorrencia(Guid id, Guid idTipoOcorrencia, string descricao)
        {
            Id = id;
            IdTipoOcorrencia = idTipoOcorrencia;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            DataEdicao = DateTime.Now;
        }
    }
}