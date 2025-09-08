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
     public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
     {
          private readonly AppDbContext _context;
          public DeleteUserCommandHandler(AppDbContext context)
          {
               _context = context;
          }

          public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
          {
               var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken);
               if (user != null)
               {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync(cancellationToken);
               }
               return Unit.Value;
          }
     }
}
