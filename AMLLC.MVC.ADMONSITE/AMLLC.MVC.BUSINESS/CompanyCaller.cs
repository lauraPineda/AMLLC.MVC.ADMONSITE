using System;
using AMLLC.CORE.ENTITIES;
using AMLLC.MVC.COMMON;

namespace AMLLC.MVC.BUSINESS
{
    public class CompanyCaller<TResponse,TRequest> : ICRUD<TResponse,TRequest>
    {
        RestClient<TResponse, TRequest> restClient;
        public CompanyCaller()
        {
            this.restClient = new RestClient<TResponse, TRequest>();
        }

        public ResponseDTO<TResponse> Add(RequestDTO<TRequest> request)
        {
            throw new NotImplementedException();
        }

        public ResponseDTO<TResponse> GetAll(RequestDTO<TRequest> request)
        {
            var response = restClient.Call(request,Key.CompanyGetAll()).Result;
            return response;
        }

        public ResponseDTO<TResponse> GetById(RequestDTO<TRequest> request)
        {
            throw new NotImplementedException();
        }

        public ResponseDTO<TResponse> Update(RequestDTO<TRequest> request)
        {
            throw new NotImplementedException();
        }
    }
}
