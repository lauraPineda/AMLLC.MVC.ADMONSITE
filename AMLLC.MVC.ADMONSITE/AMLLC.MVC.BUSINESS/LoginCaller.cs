using AMLLC.CORE.ENTITIES;
using AMLLC.CORE.ENTITIES.DB;
using AMLLC.CORE.ENTITIES.Login;
using AMLLC.MVC.COMMON;
using System.Threading.Tasks;

namespace AMLLC.MVC.APICLIENT
{
    public class LoginCaller
    {
        Task<ResponseDTO<LoginResponseDTO>> task;
        RestClient<LoginResponseDTO,UserDTO> restClient;

        public LoginCaller()
        {
            restClient = new RestClient<LoginResponseDTO,UserDTO>();
        }

        public ResponseDTO<LoginResponseDTO> GetLogin(UserDTO data)
        {
            var request = new RequestDTO<UserDTO>()
            {
                IdWebSite = Key.GetIdApp(),
                Signature = data,
                Token = "admin"
            };
            task = restClient.Call(request, Key.GetSupervisorLoginGet());
            return task.Result;
        }
    }
}
