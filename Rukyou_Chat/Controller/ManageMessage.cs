using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rukyou_Chat.Model.Show;

namespace Rukyou_Chat.Controller
{
    class ManageMessage
    {
        private string room;

        public ManageMessage(string room)
        {
            this.room = room;
        }

        public List<string> showMessages()
        {
            iShow s = new Messages(room);
            return s.show();
        }
    }
}
