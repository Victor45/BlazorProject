using BlazorProject.Application.Commands;
using BlazorProject.Domain.Entities;
using BlazorProject.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Application.Handlers
{
     public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
     {
          private readonly AppDbContext _context;
          public CreateUserCommandHandler(AppDbContext context)
          { 
               _context = context; 
          }

          public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
          {
               var user = new User
               {
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Age = command.Age
               };

               _context.Users.Add(user);
               await _context.SaveChangesAsync(cancellationToken);

               return user.Id;
          }

     }
}
