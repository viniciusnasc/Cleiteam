namespace Cleiteam.Domain.Entities
{
    public class ImagemOcorrencia : BaseEntity
    {
        public Guid IdOcorrencia { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeArquivo { get; set; }
        public int Likes { get; set; }

        public Ocorrencia Ocorrencia { get; set; }
        public UsuarioConfiguracao Usuario { get; set; }
        public List<ComentarioImagem> Comentarios { get; set; }

        public ImagemOcorrencia(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
            Likes = 0;
        }
    }
}
