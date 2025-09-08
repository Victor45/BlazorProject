using BlazorProject.Application.Commands;
using BlazorProject.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Application.Handlers
{
     public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
     {
          private readonly AppDbContext _context;
          public UpdateUserCommandHandler(AppDbContext context)
          {
               _context = context;
          }
          public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
          {
               var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken);
               if (user == null)
               {
                    return Unit.Value;
               }

               user.FirstName = request.FirstName;
               user.LastName = request.LastName;
               user.Age = request.Age;
               await _context.SaveChangesAsync(cancellationToken);

               return Unit.Value;
          }
     }
}
