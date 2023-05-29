using Abp.Application.Services.Dto;

namespace LAB.Flowers.Dto
{
    public class PagedFlowerResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

