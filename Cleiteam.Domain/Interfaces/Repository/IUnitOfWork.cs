namespace Cleiteam.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        public ITipoOcorrenciaRepository TipoOcorrenciaRepository { get; }
    }
}