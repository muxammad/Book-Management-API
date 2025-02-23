
using Book_Management.Api.Models;
using Book_Managment.Application.Exceptions;

namespace Book_Management.Api.Middlewares
{
    public class ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
    {
        private readonly RequestDelegate next = next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger = logger;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (EntityNotFoundException exception)
            {
                this.logger.LogError($"{exception}\n\n\t");
                context.Response.StatusCode = exception.StatusCode;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = exception.StatusCode,
                    Message = exception.Message
                });
            }
            catch (EntityAlreadyExistException exception)
            {
                this.logger.LogError($"{exception}\n\n\t");
                context.Response.StatusCode = exception.StatusCode;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = exception.StatusCode,
                    Message = exception.Message
                });
            }
            catch (CustomException exception)
            {
                this.logger.LogError($"{exception}\n\n\t");
                context.Response.StatusCode = exception.StatusCode;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = exception.StatusCode,
                    Message = exception.Message
                });
            }
            catch (Exception exception)
            {
                this.logger.LogError($"{exception}\n\n\t");
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = 500,
                    Message = exception.Message
                });
            }
        }
    }
}
