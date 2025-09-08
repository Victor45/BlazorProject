using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Application.Commands
{
     public record CreateUserCommand(string FirstName, string LastName, int Age) : IRequest<int>;
}
