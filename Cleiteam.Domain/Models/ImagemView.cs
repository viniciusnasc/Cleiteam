namespace Cleiteam.Domain.Models
{
    public class ImagemView
    {
        public Guid IdOcorrencia { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeArquivo { get; set; }
        public string Link { get; set; }
        public int Likes { get; set; }
    }
}