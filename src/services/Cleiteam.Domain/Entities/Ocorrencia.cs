namespace Cleiteam.Domain.Entities
{
    public class Ocorrencia : BaseEntity
    {
        public Guid IdSubtipoOcorrencia { get; set; }
        public string Descricao { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public SubtipoOcorrencia SubtipoOcorrencia { get; set; }
        public List<ImagemOcorrencia> Imagens { get; set; }
        public List<UsuarioOcorrencia> Usuarios { get; set; }
    }
}