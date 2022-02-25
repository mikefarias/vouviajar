using FluentValidation;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.ExcluirEvento
{
    public class ExcluirEventoValidator : AbstractValidator<ExcluirEventoCommand>
    {
        public ExcluirEventoValidator()
        {
            RuleFor(r => r.ID).GreaterThan(0).WithMessage("Necessário informar ID maior que zero.");
        }
    }
}
