using Casgem_Mediator.MediatorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetProductUpdateByIDQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
