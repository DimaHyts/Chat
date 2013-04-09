using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat2._0.ServiceReference1;

namespace Client
{
    class ServerConnection
    {
        private static Service1Client connect;
        public static Service1Client Connect
        {
            get
            {
                if (connect == null)
                {
                    connect = new Service1Client();
                }
                return connect;
            }
        }


    }
}
