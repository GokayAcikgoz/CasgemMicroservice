using CasgemMicroservice.Shared.Dtos;
using CasgemMicroservices.Services.Discount.Dtos;
using CasgemMicroservices.Services.Discount.Models;

namespace CasgemMicroservices.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDto>>> GetAllDiscountsCouponsAsync();
        Task<Response<ResultDiscountDto>> GetByIdDiscountCouponsAsync(int id);
        Task<Response<NoContent>> CreateDiscountCouponsAsync(CreateDiscountDto createDiscountDto);
        Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto);
        Task<Response<NoContent>> DeleteDiscountCouponsAsync(int id);

    }
}
