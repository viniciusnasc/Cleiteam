using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cleiteam.Data.Repositorys
{
    internal class OcorrenciaRepository : BaseRepository<Ocorrencia>, IOcorrenciaRepository
    {
        public OcorrenciaRepository(CleiteamContext context) : base(context)
        {}

        public async Task<List<Ocorrencia>> BuscarVarios(long latitude, long longitude, int rangeDistancia)
        {
            FormattableString query = $@"
;WITH relacao AS (
    SELECT DISTINCT 
    p.*,
    CAST('POINT(' + CAST(p.Latitude AS VARCHAR(20)) + ' ' + CAST(p.Longitude AS VARCHAR(20)) + ')' AS GEOGRAPHY).STDistance(
    CAST('POINT(' + {latitude.ToString()} + ' ' + {longitude.ToString()} + ')' AS GEOGRAPHY)) AS distance
FROM dbo.Ocorrencias p   
)
SELECT *
  FROM relacao r
 WHERE r.distance <= {rangeDistancia};";

            var result = _context.Ocorrencias.FromSql(query);
           
            return result.ToList();
        }
    }
}
