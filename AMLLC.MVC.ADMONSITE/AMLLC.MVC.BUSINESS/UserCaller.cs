using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.DB;
using AMLLC.CORE.ENTITIES.User;
using AMLLC.MVC.COMMON;

namespace AMLLC.MVC.BUSINESS
{
    public class UserCaller
    {

        ResponseDTO<int> response;
        RestClient<int, UserRequestDTO> restClient;

        /// <summary>
        /// Inicializa un objeto de la clase UserCaller.
        /// </summary>
        public UserCaller()
        {
            restClient = new RestClient<int, UserRequestDTO>();
        }

        /// <summary>
        /// Invoca AddUser api rest.
        /// </summary>
        /// <param name="data">UserRequestDTO</param>
        /// <returns></returns>
        public ResponseDTO<int> AddUser(UserRequestDTO data)
        {
            var request = new RequestDTO<UserRequestDTO>()
            {
                IdWebSite = Key.GetIdApp(),
                Signature = data,
                Token = "admin"
            };
            response = restClient.Call(request,Key.GetUserAdd()).Result;
            return response;
        }
    }
}
