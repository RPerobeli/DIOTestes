using Microsoft.Extensions.Logging;
using Moq;
using Vaquinha.MVC.Controllers;
using Vaquinha.Domain;
using FluentAssertions;
using NToastNotify;
using Xunit;
using Vaquinha.Service;
using Vaquinha.Tests.Common.Fixtures;
using Vaquinha.Domain.ViewModels;

namespace Vaquinha.Unit.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        private readonly Mock<IHomeInfoService> _homeInfoService = new Mock<IHomeInfoService>();
        private readonly Mock<ILogger<HomeController>> _logger = new Mock<ILogger<HomeController>>();
        private readonly Mock<IToastNotification> _toastNotification = new Mock<IToastNotification>();

        private HomeController _homeController;
        private readonly HomeFixture _homeFixture;

        //private _homeServiceValida = 

        public HomeControllerTests(HomeFixture homeFixture)
        {
            _homeFixture = homeFixture;
        }

        [Fact]
        [Trait("HomeController", "Index_IndexTipoValido")] 
        public void HomeController_IndexTipoValido()
        {
            //Arrange
            _homeController = new HomeController(_logger.Object,_homeInfoService.Object, _toastNotification.Object);
            //Act
            var retorno = _homeController.Index();
            //Assert
            retorno.Should().BeOfType<HomeViewModel>();
        }
        public void HomeController_IndexComDadosValidos()
        {
            //Act
            var viewModelRetornado =_homeFixture.ServiceRetornaDadosValidos(_homeInfoService.Object);
            //Assert
            viewModelRetornado.Should().BeOfType<HomeViewModel>();
        }
    }
}
