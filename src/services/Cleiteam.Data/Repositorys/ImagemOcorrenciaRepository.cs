using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleiteam.Data.Repositorys
{
    internal class ImagemOcorrenciaRepository : BaseRepository<ImagemOcorrencia>, IImagemOcorrenciaRepository
    {
        public ImagemOcorrenciaRepository(CleiteamContext context) : base(context)
        {
        }
    }
}
