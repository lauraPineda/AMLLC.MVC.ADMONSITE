﻿using System.Configuration;

namespace AMLLC.MVC.COMMON
{
    public static class Key
    {
        /// <summary>
        /// Return Key: IdApp
        /// </summary>
        public static int GetIdApp(){ return int.Parse(ConfigurationManager.AppSettings["IdApp"]); }

        /// <summary>
        /// Return Key: Error
        /// </summary>
        public static string GetError() { return ConfigurationManager.AppSettings["Error"].ToString(); }

        /// <summary>
        /// Return Key: BaseApiAdress
        /// </summary>
        public static string GetBaseApiAdress() { return ConfigurationManager.AppSettings["BaseApiAdress"].ToString(); }

        /// <summary>
        /// Return Key: SupervisorLoginGet
        /// </summary>
        public static string GetSupervisorLoginGet() { return ConfigurationManager.AppSettings["SupervisorLoginGet"].ToString(); }

        
    }
}