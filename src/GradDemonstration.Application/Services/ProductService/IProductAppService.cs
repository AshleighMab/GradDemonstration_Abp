using Abp.Application.Services;
using GradDemonstration.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Services.ProductService
{
    public interface IProductAppService:IApplicationService
    {

        Task<ProductDto> CreateAsync(ProductDto input);
        Task<ProductDto> GetAsync(Guid id);
        Task<List<ProductDto>> GetAllAsync();
        Task<ProductDto> UpdateAsync(ProductDto input);
        Task Delete(Guid id);
    }
}
