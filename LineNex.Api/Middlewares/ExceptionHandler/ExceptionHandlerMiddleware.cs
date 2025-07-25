using System.Text.Json;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace LineNex.Api.ExceptionHendler
{
    public class ExceptionHendlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHendlerMiddleware> logger;

        public ExceptionHendlerMiddleware(RequestDelegate next, ILogger<ExceptionHendlerMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unhandled exception occurred.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            object response = new { error = "An unexpected error occurred." };

            switch (exception)
            {
                case NotFoundException:
                    logger.LogError("NotFound exception occurred.");
                    statusCode = HttpStatusCode.NotFound;
                    response = new { error = "The requested resource was not found." };
                    break;

                case BadRequestException:
                    logger.LogError("BadRequest exception occurred.");
                    statusCode = HttpStatusCode.BadRequest;
                    response = new { error = exception.Message };
                    break;

                case UnauthorizedException:
                    logger.LogError("Unhandled exception occurred.");
                    statusCode = HttpStatusCode.Unauthorized;
                    response = new { error = "Unauthorized access." };
                    break;

                case ForbiddenException:
                    logger.LogError("Forbidden exception occurred.");
                    statusCode = HttpStatusCode.Forbidden;
                    response = new { error = "Access is forbidden." };
                    break;

                case ConflictException:
                    logger.LogError("Conflict exception occurred.");
                    statusCode = HttpStatusCode.Conflict;
                    response = new { error = exception.Message };
                    break;

                case ValidationException ve:
                    logger.LogError("Validation exception occurred.");
                    statusCode = HttpStatusCode.UnprocessableEntity;
                    response = new
                    {
                        error = ve.Message,
                        errors = ve.Errors
                    };
                    break;

                default:
                    response = new { error = exception.Message };
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var json = JsonSerializer.Serialize(response);
            return context.Response.WriteAsync(json);
        }
    }
}