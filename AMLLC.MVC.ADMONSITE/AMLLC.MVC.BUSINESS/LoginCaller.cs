using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.DB;
using AMLLC.CORE.ENTITIES.Login;
using AMLLC.MVC.COMMON;

namespace AMLLC.MVC.APICLIENT
{
    public class LoginCaller
    {
        ResponseDTO<LoginResponseDTO> response;
        RestClient<LoginResponseDTO,UserDTO> restClient;

        /// <summary>
        /// Inicializa un objeto de la clase LoginCaller.
        /// </summary>
        public LoginCaller()
        {
            restClient = new RestClient<LoginResponseDTO,UserDTO>();
        }

        /// <summary>
        /// Incova login api rest.
        /// </summary>
        /// <param name="data">UserDTO</param>
        /// <returns></returns>
        public ResponseDTO<LoginResponseDTO> GetLogin(UserDTO data)
        {
            var request = new RequestDTO<UserDTO>()
            {
                IdWebSite = Key.GetIdApp(),
                Signature = data,
                Token = "admin"
            };
            response = restClient.Call(request, Key.GetLoginGet()).Result;
            return response;
        }
    }
}
