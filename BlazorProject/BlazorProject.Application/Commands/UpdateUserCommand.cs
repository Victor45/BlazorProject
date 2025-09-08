using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Application.Commands
{
     public record UpdateUserCommand(int Id, string FirstName, string LastName, int Age) : IRequest<Unit>;
}
