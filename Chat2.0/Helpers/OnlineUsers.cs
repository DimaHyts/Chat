using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;
using Chat2._0.ServiceReference1;

namespace Chat2._0.Helpers
{
    public class OnlineUsers
    {
        private List<UserUI> userUIList = new List<UserUI>();
        private List<UserDTO> userDTOList = new List<UserDTO>();
        public List<UserUI> CheckOnlineUsers()
        {
            userDTOList= ServerConnection.Connect.GetOnlineUser().ToList();
            userDTOList.ForEach (m=> userUIList.Add(new UserUI(m)));
            return userUIList;
        }
    }
}
