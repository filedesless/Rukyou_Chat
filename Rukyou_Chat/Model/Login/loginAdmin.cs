using System;

namespace Rukyou_Chat.Model.Login
{
    class loginAdmin : iLogin
    {
        private string username;
        private string password;

        public loginAdmin(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }

        public bool success()
        {
            throw new NotImplementedException();
        }
    }
}
