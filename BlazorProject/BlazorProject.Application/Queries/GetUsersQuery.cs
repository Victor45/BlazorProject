using BlazorProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Application.Queries
{
     public record GetUsersQuery : IRequest<List<User>>;
}
