using Abp.Application.Services;
using LAB.Flowers.Dto;

namespace LAB.Flowers
{
    public interface IFlowerAppService : IAsyncCrudAppService<FlowerDto, long, PagedFlowerResultRequestDto, FlowerDto, FlowerDto>
    {

    }
}

