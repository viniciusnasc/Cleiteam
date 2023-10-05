using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;

namespace Cleiteam.Data.Repositorys
{
    internal class ImagemOcorrenciaRepository : BaseRepository<ImagemOcorrencia>, IImagemOcorrenciaRepository
    {
        public ImagemOcorrenciaRepository(CleiteamContext context) : base(context)
        {}
    }
}