using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Cleiteam.Domain.Models
{
    public class OcorrenciaInputModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid IdSubtipoOcorrencia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        [Range(-90, 90, ErrorMessage = "Deve ter n")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(-180, 180, ErrorMessage = "Deve ter entre {0} e {1}")]
        public double Longitude { get; set; }

        public IFormFile Imagem { get; set; }
    }
}