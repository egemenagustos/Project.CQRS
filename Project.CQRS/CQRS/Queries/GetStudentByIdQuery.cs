using MediatR;
using Project.CQRS.CQRS.Result;

namespace Project.CQRS.CQRS.Queries
{
    public class GetStudentByIdQuery : IRequest<GetStudentByIdQueryResult>
    {
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
