using Cleiteam.Data.Context;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleiteamContext _context;
        public IComentarioImagemRepository ComentarioImagemRepository { get; }
        public IImagemOcorrenciaRepository ImagemOcorrenciaRepository { get; }
        public ITipoOcorrenciaRepository TipoOcorrenciaRepository { get; }
        public IOcorrenciaRepository OcorrenciaRepository { get; }
        public ISubtipoOcorrenciaRepository SubtipoOcorrenciaRepository { get; }
        public IUsuarioConfiguracaoRepository UsuarioConfiguracaoRepository { get; }

        public UnitOfWork(CleiteamContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            ComentarioImagemRepository = new ComentarioImagemRepository(context);
            ImagemOcorrenciaRepository = new ImagemOcorrenciaRepository(context);
            TipoOcorrenciaRepository = new TipoOcorrenciaRepository(context);
            OcorrenciaRepository = new OcorrenciaRepository(context);
            SubtipoOcorrenciaRepository = new SubtipoOcorrenciaRepository(context);
            UsuarioConfiguracaoRepository = new UsuarioConfiguracaoRepository(context);
        }
    }
}