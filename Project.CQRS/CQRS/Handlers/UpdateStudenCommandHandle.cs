using MediatR;
using Project.CQRS.CQRS.Commands;
using Project.CQRS.Data;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project.CQRS.CQRS.Handlers
{
    public class UpdateStudenCommandHandle : IRequestHandler<UpdateStudentCommand>
    {
        private readonly Context _context;

        public UpdateStudenCommandHandle(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var updatedStudent = _context.Students.Find(request.Id);
            updatedStudent.Age = request.Age;
            updatedStudent.Name = request.Name;
            updatedStudent.Surname = request.Surname;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
