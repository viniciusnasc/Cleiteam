namespace Cleiteam.Domain.Models
{
    public class UsuarioView
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Alcance { get; set; }
        public bool ReceberNotificacao { get; set; }
    }
}