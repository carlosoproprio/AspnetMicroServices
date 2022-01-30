using System;
using System.Threading.Tasks;
using Discount.GRPC;

namespace Basket.API.GRPCServices
{
    public class DiscountGRPCService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGRPCService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoService));
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest() {ProductName = productName};
            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }
    }
}
