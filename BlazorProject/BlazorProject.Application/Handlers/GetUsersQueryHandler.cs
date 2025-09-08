using BlazorProject.Application.Queries;
using BlazorProject.Domain.Entities;
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
     public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
     {
          public readonly AppDbContext _context;
          public GetUsersQueryHandler(AppDbContext context)
          {
               _context = context;
          }
          public async Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
          {
               return await _context.Users.ToListAsync(cancellationToken);
          }
     }
}
