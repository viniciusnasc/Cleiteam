namespace Cleiteam.Domain.Entities
{
    public class TipoOcorrencia : BaseEntity
    {
        public string Descricao { get; set; }

        public List<Ocorrencia> Ocorrencias { get; set; }

        public TipoOcorrencia(string descricao)
        {
            Descricao = descricao;
        }
    }
}