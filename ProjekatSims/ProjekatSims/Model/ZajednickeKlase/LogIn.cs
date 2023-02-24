/***********************************************************************
 * Module:  LogIn.cs
 * Purpose: Definition of the Class Model.ZajednickeKlase.LogIn
 ***********************************************************************/

using System;

namespace Model.ZajednickeKlase
{
   public class LogIn
    {
        private LogInController _logInController;

        private static LogIn instance = null;
        private String _username;
        private String _password;
        public Dictionary<String, String> users = new Dictionary<String, String>();

        public LogIn(String username, String password)
        {
            _username = username;
            _password = password;
        }

        private LogIn()
        {
             App app = Application.Current as App;
            _logInController = app.LogInController;
            foreach(LogIn usr in _logInController.GetAll())
            {
                users.Add(usr.Username, usr.Password);
                _username = usr.Username;
                _password = usr.Password;
            }
        }

        public static LogIn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogIn();
                }
                return instance;
            }
        }

        public String Username
        {
            get
            {
                return _username;
            }
        }

        public String Password
        {
            get
            {
                return _password;
            }
        }
    }
}