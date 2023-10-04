namespace Cleiteam.Domain.Entities
{
    public class ImagemOcorrencia : BaseEntity
    {
        public int IdOcorrencia { get; set; }
        public int IdUsuario { get; set; }
        public string NomeArquivo { get; set; }
        public int Likes { get; set; }

        public Ocorrencia Ocorrencia { get; set; }
        public Usuario Usuario { get; set; }

        public ImagemOcorrencia(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
            Likes = 0;
        }
    }
}
