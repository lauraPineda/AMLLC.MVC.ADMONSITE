﻿using System.Configuration;
using System.Text;

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
        /// Return Key:LogNameTxt
        /// </summary>
        public static string GetLogNameTxt() { return ConfigurationManager.AppSettings["LogNameTxt"].ToString(); }

        /// <summary>
        /// Return Key: LoginGet
        /// </summary>
        public static string GetLoginGet() { return ConfigurationManager.AppSettings["LoginGet"].ToString(); }

        /// <summary>
        /// Return Key: UserAdd
        /// </summary>
        public static string GetUserAdd() { return ConfigurationManager.AppSettings["UserAdd"].ToString(); }

        #region Company
        /// <summary>
        /// Return Key: Company + GetAll
        /// </summary>
        public static string CompanyGetAll() { return new StringBuilder()
                .Append(ConfigurationManager.AppSettings["Company"].ToString())
                .Append(ConfigurationManager.AppSettings["GetAll"].ToString())
                .ToString(); }
        #endregion

    }
}
