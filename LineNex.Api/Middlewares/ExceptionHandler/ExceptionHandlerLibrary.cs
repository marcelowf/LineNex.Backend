namespace LineNex.Api.ExceptionHendler
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message) { }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }

    }

    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message) : base(message) { }
    }

    public class ForbiddenException : Exception
    {
        public ForbiddenException(string message) : base(message) { }
    }

    public class ConflictException : Exception
    {
        public ConflictException(string message) : base(message) { }
    }

    public class ValidationException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException(string message, IDictionary<string, string[]> errors = null)
            : base(message)
        {
            Errors = errors ?? new Dictionary<string, string[]>();
        }
    }
}