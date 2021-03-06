﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
using System.Runtime.Serialization;

namespace EntitiesDTO
{
    [Serializable]
    [DataContract]
    public class MessageDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public UserDTO UserFrom { get; set; }
        [DataMember]
        public UserDTO UserTo { get; set; }

        public MessageDTO()
        { 
        }

        public MessageDTO(Message message)
        {
            this.Id = message.Id;
            this.Text = message.Text;
            this.Date = message.Date;
            this.UserFrom = new UserDTO(message.User_From);
            this.UserTo =message.User_To ==null? null: new UserDTO(message.User_To);
        }

        public Message ToDB()
        {
            var mess = new Message()
            {

                Text = this.Text,
                Date = this.Date,
                UserFrom = this.UserFrom.Id,
            };

            if (UserTo != null)
                mess.UserTo = UserTo.Id;

            return mess;
        }
    }
}
