using MediatR;
using Project.CQRS.CQRS.Commands;
using Project.CQRS.Data;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project.CQRS.CQRS.Handlers
{
    public class RemoveStudentCommandHandler : IRequestHandler<RemoveStudenCommand>
    {
        private readonly Context _context;

        public RemoveStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveStudenCommand request, CancellationToken cancellationToken)
        {
            var student = _context.Students.Find(request.Id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
