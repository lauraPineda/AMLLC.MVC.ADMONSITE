
using AMLLC.CORE.ENTITIES;

namespace AMLLC.MVC.BUSINESS
{
    public interface ICRUD<TResponse,TRequest>
    {
        ResponseDTO<TResponse> Add(RequestDTO<TRequest> request);
        ResponseDTO<TResponse> Update(RequestDTO<TRequest> request);
        ResponseDTO<TResponse> GetById(RequestDTO<TRequest> request);
        ResponseDTO<TResponse> GetAll(RequestDTO<TRequest> request);
    }
}
