using Abp.Application.Services.Dto;

namespace LAB.Bouquets.Dto
{
    public class PagedBouquetResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

