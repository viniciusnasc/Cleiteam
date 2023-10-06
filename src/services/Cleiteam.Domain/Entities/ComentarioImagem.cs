namespace Cleiteam.Domain.Entities
{
    public class ComentarioImagem : BaseEntity
    {
        public Guid IdImagem { get; set; }
        public Guid IdUsuario { get; set; }
        public string Comentario { get; set; }

        public ImagemOcorrencia Imagem { get; set; }
        public UsuarioConfiguracao Usuario { get; set; }
    }
}