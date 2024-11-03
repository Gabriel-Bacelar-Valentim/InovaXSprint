using InovaX.Services.CEP;
using Xunit;

namespace InovaX.Services.Test.CEP
{
    public class CEPServiceTests
    {
        private readonly CEPService _cepService;
        private const string ValidCEP = "01001-000";
        private const string InvalidCEP = "99999-999";

        public CEPServiceTests()
        {
            _cepService = new CEPService();
        }

        [Fact]
        public async Task FindCEP_ReturnsAddressResponse_WhenCEPIsValid()
        {
            var addressResult = await _cepService.FindCEP(ValidCEP);

            Assert.NotNull(addressResult);
            Assert.Equal("3550308", addressResult.IBGE);
        }

        [Fact]
        public async Task FindCEP_ReturnsNull_WhenCEPIsInvalid()
        {
            var addressResult = await _cepService.FindCEP(InvalidCEP);

            Assert.Null(addressResult);
        }
    }
}