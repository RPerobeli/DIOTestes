using System;
using System.Collections.Generic;
using System.Text;
using Vaquinha.Domain.ViewModels;
using Xunit;
using Vaquinha.Domain;
using Bogus;
using Bogus.DataSets;
using System.Threading.Tasks;
using Moq;

namespace Vaquinha.Tests.Common.Fixtures
{
    [CollectionDefinition(nameof(HomeFixtureCollection))]
    public class HomeFixtureCollection : ICollectionFixture<HomeFixture>, ICollectionFixture<EnderecoFixture>, ICollectionFixture<CartaoCreditoFixture>
    {
    }
    public class HomeFixture
    {
        public Task<HomeViewModel> ServiceRetornaDadosValidos(IHomeInfoService homeService)
        {
            var dadosIniciaisHome = homeService.RecuperarDadosIniciaisHomeAsync();

            return dadosIniciaisHome;
        }
    }
}
