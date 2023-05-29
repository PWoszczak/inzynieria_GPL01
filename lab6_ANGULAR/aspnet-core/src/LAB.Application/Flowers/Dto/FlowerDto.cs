using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Flowers.Dto
{
    [AutoMapFrom(typeof(Flower))]
    public class FlowerDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

