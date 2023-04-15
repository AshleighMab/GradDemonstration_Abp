using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using AutoMapper;
using GradDemonstration.Authorization;
using GradDemonstration.Authorization.Users;
using GradDemonstration.Domain;
using GradDemonstration.Services.Dto;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Services.ProductService
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductAppService :ApplicationService, IProductAppService
    {
        private readonly IRepository<Product,Guid> _productAppService;
        public ProductAppService(IRepository<Product, Guid> productAppService)
        {
           _productAppService = productAppService;
        }

        [AbpAuthorize(PermissionNames.Pages_Products_Create)]
        [HttpPost]
        public async Task<ProductDto> CreateAsync(ProductDto input)
        {
           return ObjectMapper.Map<ProductDto>( await _productAppService.InsertAsync(ObjectMapper.Map<Product>(input)));
        }

        [HttpGet]
        public async Task<List<ProductDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<ProductDto>>(await _productAppService.GetAllListAsync());
        }

        [HttpGet]
        public async Task<ProductDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<ProductDto>(await _productAppService.GetAsync(id));
        }

        [AbpAuthorize(PermissionNames.Pages_Products_Update)]
        [HttpPut]
        public async Task<ProductDto> UpdateAsync(ProductDto input)
        {
            var product = await _productAppService.GetAsync(input.Id);
            ObjectMapper.Map(product, input);
            return ObjectMapper.Map<ProductDto>(product);
        }

        [AbpAuthorize(PermissionNames.Pages_Products_Delete)]
        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _productAppService.DeleteAsync(id);
        }

    }
}
