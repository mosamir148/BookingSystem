using BookingSystem.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Validators
{
    public class CreateBookingRequestValidator : AbstractValidator<CreateBookingRequest>
    {
        public CreateBookingRequestValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty().WithMessage("CustomerId is required");

            RuleFor(x => x.ServiceId)
                .GreaterThan(0).WithMessage("Invalid ServiceId");

            RuleFor(x => x.TimeSlotId)
                .GreaterThan(0).WithMessage("Invalid TimeSlotId");
        }
    }
}
