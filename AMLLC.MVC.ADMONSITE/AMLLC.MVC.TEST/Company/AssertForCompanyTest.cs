using AMLLC.CORE.ENTITIES;
using System.Collections.Generic;

namespace AMLLC.MVC.TEST.Company
{
    internal static class AssertForCompanyTest
    {

        public static ResponseDTO<object>ResponseOk()
        {
            return new ResponseDTO<object>();
        }

        public static RequestDTO<object> RequestGetAllOk()
        {
            return new RequestDTO<object>() {
                Signature = true
            };
        }

        public static ResponseDTO<List<CatalogsDTO>> ResponseGetAllOk()
        {
            var list = new List<CatalogsDTO>();
            for (int x = 1; x <= 1; x++)
            {
                list.Add(new CatalogsDTO() { Id = x, Description = "mock Company x", Enabled = true, Name ="Company x" });
            }

            var response = new ResponseDTO<List<CatalogsDTO>>()
            {
                Message = "OK",
                Success = true,
                Result = list
            };
            return response;
        }
    }
}
