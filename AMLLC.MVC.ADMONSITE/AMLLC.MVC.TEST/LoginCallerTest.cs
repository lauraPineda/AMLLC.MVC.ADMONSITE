using Microsoft.VisualStudio.TestTools.UnitTesting;
using AMLLC.MVC.APICLIENT;
using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.Login;
using AMLLC.CORE.ENTITIES.DB;

namespace AMLLC.MVC.TEST
{
    [TestClass]
    public class LoginCallerTest
    {
        LoginCaller loginCaller;
        ResponseDTO<LoginResponseDTO> response;

        [TestInitialize]
        void InitializeTest()
        {
            loginCaller = new LoginCaller();
            response = new ResponseDTO<LoginResponseDTO>();
        }

        [TestMethod]
        public void GetLogin()
        {
            InitializeTest();
            response = loginCaller.GetLogin(new UserDTO() { UserName = "Jorge", Password = "TextPassword" });
            AssertsForLoginTest.AssertResponseOK(response);
        }
    }
}
