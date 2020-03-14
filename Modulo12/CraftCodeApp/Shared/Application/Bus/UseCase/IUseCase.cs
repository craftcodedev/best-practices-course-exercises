﻿using System;
namespace CraftCodeApp.src.Shared.Application.Bus.UseCase
{
    public interface IUseCase
    {
        IResponse Execute(IRequest req);
    }
}
