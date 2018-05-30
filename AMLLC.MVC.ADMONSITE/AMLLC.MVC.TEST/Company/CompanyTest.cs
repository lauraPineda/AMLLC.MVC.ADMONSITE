using AMLLC.CORE.ENTITIES;
using AMLLC.MVC.BUSINESS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace AMLLC.MVC.TEST.Company
{
    [TestClass]
    public class CompanyTest
    {
        private Mock<ICRUD<object,object>> mockedICRUD;
        private RequestDTO<object> mockRequest;
        private ResponseDTO<object> mockResponse;

        [TestInitialize]
        public void TestInitialize()
        {
            mockedICRUD = new Mock<BUSINESS.ICRUD<object, object>>();
        }

        [TestMethod]
        public void GetAllOK()
        {
            mockRequest = AssertForCompanyTest.RequestGetAllOk();
            //mockResponse = Convert.ChangeType(AssertForCompanyTest.ResponseGetAllOk(),ResponseDTO<object>);
            InitializeMocks();

        }

        private void InitializeMocks()
        {
            mockedICRUD.Setup(x => x.GetAll(mockRequest)).Returns(mockResponse);
        }

        private object GetAll()
        {
            var response = mockedICRUD.Object.GetAll(mockRequest);
            return response;
        }
    }
}
