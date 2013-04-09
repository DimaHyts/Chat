using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public static class ConnectDB
    {
        private static ChatEntities contex;
        public static ChatEntities Context
        {
            get
            {
                if (contex == null)
                {
                    contex = new ChatEntities();
                }
                return contex;
            }
        }
    }
}
