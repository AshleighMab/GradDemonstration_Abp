﻿using System.Threading.Tasks;
using GradDemonstration.Models.TokenAuth;
using GradDemonstration.Web.Controllers;
using Shouldly;
using Xunit;

namespace GradDemonstration.Web.Tests.Controllers
{
    public class HomeController_Tests: GradDemonstrationWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}