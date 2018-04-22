using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.Login;
using FluentAssertions;

namespace AMLLC.MVC.TEST
{
    internal static class AssertsForLoginTest
    {
        internal static void AssertResponseOK(ResponseDTO<LoginResponseDTO> response)
        {
            response.Should().NotBeNull();
            response.Success.Should().BeTrue();
            response.Result.Should().NotBeNull();
            response.Result.IsAuthenticated.Should().BeTrue();
            response.Result.User.Should().NotBeNull();
            response.Result.Role.Should().NotBeNull();
            response.Result.Role.IdRole.Should().BeGreaterThan(0);
            response.Result.Role.Name.Length.Should().BeGreaterThan(0);
        }
    }
}
