using MediatR;

namespace Book_Managment.Application.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }

}
