﻿using AutoMapper;
using MediatR;
using Swipepick.Angular.Domain;
using Swipepick.Angular.Infrastructure.Abstractions.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace Swipepick.Angular.UseCases.Users.AddUser;

internal class AddUserCommandHandler : IRequestHandler<AddUserCommand>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    public AddUserCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    public async Task Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var user = mapper.Map<User>(request);
        HashPassword(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
        user.PasswordHash = passwordHash;
        user.PasswordSalt = passwordSalt;
        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    private void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
