using Cleiteam.Domain.Entities;
using FluentValidation;

namespace Cleiteam.Domain.Validations
{
    public class TipoOcorrenciaValidation : AbstractValidator<TipoOcorrencia>
    {
        public TipoOcorrenciaValidation()
        {
            RuleFor(d => d.Descricao).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}