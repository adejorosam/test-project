﻿using System;
using FluentValidation;
namespace crud_api.Validators
{
    public class UpdateWalkRequestValidator: AbstractValidator<Models.DTO.UpdateWalkRequest>
    {
        public UpdateWalkRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            //RuleFor(x => x.RegionId).NotEmpty();
            RuleFor(x => x.Length).GreaterThan(0);
        }
    }
}

