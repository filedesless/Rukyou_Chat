using Rukyou_Chat.Model.Login;

namespace Rukyou_Chat.Controller
{
    class ManageUser
    {
        public bool login(string user, string pass)
        {
            return new loginUser(user, pass).success();
        }
    }
}
