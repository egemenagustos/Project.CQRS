using MediatR;
using Project.CQRS.CQRS.Commands;
using Project.CQRS.Data;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project.CQRS.CQRS.Handlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly Context _context;

        public CreateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            await _context.Students.AddAsync(new Student
            {
                Name = request.Name,
                Age = request.Age,
                Surname = request.Surname,
            });
           await _context.SaveChangesAsync();
           return Unit.Value;
        }
    }
}
