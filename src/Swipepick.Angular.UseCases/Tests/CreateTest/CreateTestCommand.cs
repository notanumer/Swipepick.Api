﻿using MediatR;
using Swipepick.Angular.DomainServices;

namespace Swipepick.Angular.UseCases.Tests.CreateTest;

public record CreateTestCommand : IRequest<string>
{
    required public string UserEmail { get; init; }

    required public CreateTestDto TestDto { get; init; }
}
