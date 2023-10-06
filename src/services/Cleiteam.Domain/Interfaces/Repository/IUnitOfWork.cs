namespace Cleiteam.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        public IComentarioImagemRepository ComentarioImagemRepository { get; }
        public IImagemOcorrenciaRepository ImagemOcorrenciaRepository { get; }
        public ISubtipoOcorrenciaRepository SubtipoOcorrenciaRepository { get; }
        public ITipoOcorrenciaRepository TipoOcorrenciaRepository { get; }
        public IOcorrenciaRepository OcorrenciaRepository { get; }
        public IUsuarioConfiguracaoRepository UsuarioConfiguracaoRepository { get;}
        public IUsuarioOcorrenciaRepository UsuarioOcorrenciaRepository { get; }
    }
}