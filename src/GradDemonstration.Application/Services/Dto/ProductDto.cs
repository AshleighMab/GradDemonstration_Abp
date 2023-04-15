using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using GradDemonstration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Services.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto:EntityDto<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ProductDescription { get; set; }
    }
}
