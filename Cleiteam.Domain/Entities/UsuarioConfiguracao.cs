namespace Cleiteam.Domain.Entities
{
    public class UsuarioConfiguracao : BaseEntity
    {
        public string Nome { get; set; }
        public int Alcance { get; set; }
        public bool ReceberNotificacao { get; set; }

        public List<UsuarioOcorrencia> Ocorrencias { get; set; }
        public List<ImagemOcorrencia> Imagens { get; set; }
        public List<ComentarioImagem> Comentarios { get; set; }

       
    }
}