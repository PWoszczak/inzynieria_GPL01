using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Flowers;
using LAB.Flowers.Dto;

namespace LAB.Cars
{
    public class FlowerAppService : AsyncCrudAppService<Flower, FlowerDto, long, PagedFlowerResultRequestDto, FlowerDto, FlowerDto>, IFlowerAppService
    {
        public FlowerAppService(IRepository<Flower, long> repository) : base(repository)
        {
        }
    }
}

