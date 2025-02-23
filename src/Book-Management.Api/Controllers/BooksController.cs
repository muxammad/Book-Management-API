using Book_Managment.Application.UseCases.Books.Commands.Add;
using Book_Managment.Application.UseCases.Books.Commands.Delete;
using Book_Managment.Application.UseCases.Books.Commands.Update;
using Book_Managment.Application.UseCases.Books.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BooksController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator mediator = mediator;

        [HttpPost("create")]
        public async Task<IActionResult> CreateBook([FromBody] AddBookCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteBook([FromBody] DeleteBookCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetBooksById([FromQuery] GetBookByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-all-books-title")]
        public async Task<IActionResult> GetAllBooks([FromQuery] GetBooksTitlesQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-all-books-details")]

        public async Task<IActionResult> GetAllBooksDetails([FromQuery] GetAllBookDetailsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);

        }
    }
}
