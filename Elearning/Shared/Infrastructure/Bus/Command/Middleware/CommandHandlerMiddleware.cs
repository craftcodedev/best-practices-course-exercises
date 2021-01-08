using elearning.Shared.Domain.Bus.Command;

namespace elearning.Shared.Infrastructure.Bus.Command.Middleware
{
    public class CommandHandlerMiddleware : MiddlewareHandler
    {
        private readonly ICommandHandler commandHandler;

        public CommandHandlerMiddleware(ICommandHandler commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public override void Handle(ICommand command)
        {
            commandHandler.Handle(command);
        }
    }
}