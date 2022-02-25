using FluentValidation;

namespace VouViajar.Modulos.Eventos.Application.Features.Commands.AtualizarEvento
{
    public class AtualizarEventoValidator : AbstractValidator<AtualizarEventoCommand>
    {
        public AtualizarEventoValidator()
        {
            RuleFor(r => r.ID).GreaterThan(0).WithMessage("Necessário informar ID maior que zero.");
            RuleFor(r => r.Nome).NotEmpty().WithMessage("Necessário informar o nome do evento.");
            RuleFor(r => r.Resumo).NotEmpty().WithMessage("Necessário informar o reusmo do evento.");
            RuleFor(r => r.DataInicio).NotEmpty().WithMessage("Necessário informar a data de início do evento.");
            RuleFor(r => r.DataInicio).NotEmpty().WithMessage("Necessário informar a data do fim do evento.");
        }
    }
}
