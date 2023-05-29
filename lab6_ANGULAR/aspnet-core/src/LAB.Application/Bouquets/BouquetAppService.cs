using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LAB.Bouquets;
using LAB.Bouquets.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LAB.Cars
{
    public class BouquetAppService : AsyncCrudAppService<Bouquet, BouquetDto, long, PagedBouquetResultRequestDto, BouquetDto, BouquetDto>, IBouquetAppService
    {
        public BouquetAppService(IRepository<Bouquet, long> repository) : base(repository)
        {
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<PagedResultDto<BouquetDto>> GetAllAsync(PagedBouquetResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
    }
}

