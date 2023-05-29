using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Bouquets.Dto
{
    [AutoMapFrom(typeof(Bouquet))]
    public class BouquetDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

