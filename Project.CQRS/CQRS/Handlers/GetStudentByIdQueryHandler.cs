using MediatR;
using Project.CQRS.CQRS.Queries;
using Project.CQRS.CQRS.Result;
using Project.CQRS.Data;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Project.CQRS.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, GetStudentByIdQueryResult>
    {
        private readonly Context _context;

        public GetStudentByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _context.Set<Student>().FindAsync(request.Id);
            return new GetStudentByIdQueryResult
            {
                Name = student.Name,
                Age = student.Age,
                Surname = student.Surname,
            };
        }

        //public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        //{
        //    var student = _context.Set<Student>().Find(query.Id);
        //    return new GetStudentByIdQueryResult
        //    {
        //        Name = student.Name,
        //        Age = student.Age,
        //        Surname = student.Surname,
        //    };
        //}
    }
}
