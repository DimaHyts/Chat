﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ConnectDB
    {
        private static ChatEntities3 context;
        public static ChatEntities3 Context
        {
            get
            {
                if (context == null)
                {
                    context = new ChatEntities3();
                }
                return context;
            }
            
        }
    }
}
