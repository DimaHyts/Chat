using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ConnectDB
    {
        private static 
        public static ChatEntities1 Context
        {
            get
            {
                if (contex == null)
                {
                    contex = new ChatEntities1();
                }
                return contex;
            }
        }

    }
}
