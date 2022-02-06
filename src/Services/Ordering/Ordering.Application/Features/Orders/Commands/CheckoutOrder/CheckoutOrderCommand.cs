using MediatR;
using Ordering.Domain.Entities;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommand : Order, IRequest<int>
    {
        public int Id { get; set; }
    }
}
