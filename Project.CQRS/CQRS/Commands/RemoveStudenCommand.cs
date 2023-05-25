using MediatR;

namespace Project.CQRS.CQRS.Commands
{
    public class RemoveStudenCommand : IRequest
    {
        public RemoveStudenCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
