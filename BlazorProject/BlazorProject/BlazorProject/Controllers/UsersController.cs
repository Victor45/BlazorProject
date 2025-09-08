using BlazorProject.Application.Commands;
using BlazorProject.Application.Queries;
using BlazorProject.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Controllers
{
     [ApiController]
     [Route("api/[controller]")]
     public class UsersController : ControllerBase
     {
          private readonly IMediator _mediator;

          public UsersController(IMediator mediator)
          {
               _mediator = mediator;
          }

          [HttpPost]
          public async Task<ActionResult<int>> CreateUser(CreateUserCommand command)
          {
               var userId = await _mediator.Send(command);
               return Ok(userId);
          }

          [HttpPut("{id}")]
          public async Task<IActionResult> UpdateUser(int Id, UpdateUserCommand command)
          {
               if (Id != command.Id)
               {
                    return BadRequest();
               }
               await _mediator.Send(command);
               return NoContent();
          }

          [HttpDelete("{id}")]
          public async Task<IActionResult> DeleteUser(int Id)
          {
               await _mediator.Send(new DeleteUserCommand(Id));
               return NoContent();
          }

          [HttpGet]
          public async Task<ActionResult<List<User>>> GetUsers()
          {
               var query = new GetUsersQuery();
               var users = await _mediator.Send(query);
               return Ok(users);
          }
     }
}
