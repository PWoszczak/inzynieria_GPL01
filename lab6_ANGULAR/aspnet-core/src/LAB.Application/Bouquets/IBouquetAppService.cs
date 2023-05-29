using Abp.Application.Services;
using LAB.Bouquets.Dto;

namespace LAB.Bouquets
{
    public interface IBouquetAppService : IAsyncCrudAppService<BouquetDto, long, PagedBouquetResultRequestDto, BouquetDto, BouquetDto>
    {

    }
}

