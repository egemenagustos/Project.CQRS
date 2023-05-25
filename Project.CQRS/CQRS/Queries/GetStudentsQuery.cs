using MediatR;
using Project.CQRS.CQRS.Result;
using System.Collections.Generic;

namespace Project.CQRS.CQRS.Queries
{
    public class GetStudentsQuery : IRequest<IEnumerable<GetStudentsQueryResult>>
    {
    }
}
