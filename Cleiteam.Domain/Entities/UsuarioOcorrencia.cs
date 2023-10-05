namespace Cleiteam.Domain.Entities
{
    public class UsuarioOcorrencia : BaseEntity
    {
        public Guid IdUsuario { get; set; }
        public Guid IdOcorrencia { get; set; }
        public bool Responsavel { get; set; }

        public Ocorrencia Ocorrencia { get; set; }
        public UsuarioConfiguracao Usuario { get; set; }
    }
}