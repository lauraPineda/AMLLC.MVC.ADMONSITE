using DLL = AMLLC.CORE.ENTITIES.Login;
using System.Web;

namespace AMLLC.MVC.COMMON
{
    public class SessionVar
    {
        protected static HttpContext context;
        protected static SessionVar instance;
        protected static readonly object _Lock = new object();

        private SessionVar() { }

        /// <summary>
        /// Inicializa todas las variables de sesión
        /// </summary>
        private SessionVar(HttpContext httpContext)
        {
            context = httpContext;
            context.Session["LoginUser"] = null;
        }

        /// <summary>
        /// Obtiene una instancia de la clase SessionVar mediante Singleton.
        /// </summary>
        /// <returns>Regresa una instancia del tipo SessionVar.</returns>
        public static SessionVar GetInstance(HttpContext context)
        {
            lock (_Lock)
            {
                if (Equals(null, instance))
                {                    
                    instance = new SessionVar(context);
                }
            }

            return instance;
        }

        /// <summary>
        /// Obtener valor directo de la varible de sesión LoginUser.
        /// </summary>
        /// <returns></returns>
        public static DLL::LoginResponseDTO GetLoginUser()
        {
            return (DLL::LoginResponseDTO)HttpContext.Current.Session["LoginUser"];
        }

        /// <summary>
        /// Asignar valor a la variable de sesión LoginUser.
        /// </summary>
        /// <param name="value"></param>
        public static void SetLoginUser(DLL::LoginResponseDTO value)
        {
            HttpContext.Current.Session["LoginUser"] = value;
        }

        /// <summary>
        /// Elimina el contenido de todas las variables de sesión.
        /// </summary>
        public static void Clean()
        {
            SetLoginUser(null);
        }

    }
}
