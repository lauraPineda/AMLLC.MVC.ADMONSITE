using AMLLC.CORE.ENTITIES;

namespace AMLLC.MVC.BUSINESS
{
    public class Invoker<TResponse, TRequest>
    {
        protected ICRUD<TResponse, TRequest> crud;

        public Invoker(ICRUD<TResponse, TRequest> crud)
        {
            this.crud = crud;
        }

        public ResponseDTO<TResponse> Add(RequestDTO<TRequest> request)
        {
            return this.crud.Add(request);
        }

        public ResponseDTO<TResponse> GetAll(RequestDTO<TRequest> request)
        {
            return this.crud.GetAll(request);
        }

        public ResponseDTO<TResponse> GetById(RequestDTO<TRequest> request)
        {
            return this.crud.GetById(request);
        }

        public ResponseDTO<TResponse> Update(RequestDTO<TRequest> request)
        {
            return this.crud.Update(request);
        }

    }
}
