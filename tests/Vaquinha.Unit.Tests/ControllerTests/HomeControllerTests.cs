using Microsoft.Extensions.Logging;
using Moq;
using Vaquinha.MVC.Controllers;
using Vaquinha.Domain;
using FluentAssertions;
using NToastNotify;
using Xunit;
using Vaquinha.Service;

namespace Vaquinha.Unit.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        private readonly Mock<IHomeInfoService> _homeInfoService = new Mock<IHomeInfoService>();
        private readonly Mock<ILogger<HomeController>> _logger = new Mock<ILogger<HomeController>>();
        private readonly Mock<IToastNotification> _toastNotification = new Mock<IToastNotification>();

        private HomeController _homeController;
        
        //private _homeServiceValida = 

        public HomeControllerTests()
        {
            
        }

        [Fact]
        [Trait("HomeController", "RecuperaDadosCorretamente")] 
        public void HomeController_RecuperaDadosCorretamente()
        {
            //Arrange
            _homeController = new HomeController(_logger.Object,_homeInfoService.Object, _toastNotification.Object);
            //Act
            var retorno = _homeController.Index();
            //Assert


        }
    }
}
