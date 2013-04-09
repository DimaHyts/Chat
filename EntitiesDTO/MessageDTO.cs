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

        public MessageDTO(Message message)
        {
            this.Id = message.Id;
            this.Text = message.Text;
            this.Date = message.Date;
            this.UserFrom = new UserDTO(message.User_From);
            this.UserTo = new UserDTO(message.User_To);
        }

        public Message ToDB()
        {
            return new Message
            {
                Id = Id,
                Text = Text,
                Date = Date,
                UserFrom = this.UserFrom.Id,
                UserTo = this.UserTo.Id
            };
        }
    }
}