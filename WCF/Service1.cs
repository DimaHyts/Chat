using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using System.Data.Entity;
using System.Data;
using EntitiesDTO;


namespace WCF
{
    public class Service1 : IService1
    {
        public Service1()
        {
        }

        private User us;
        private User currentUser
        {
            get
            {
                return us;
            }
            set
            {
                us = value;
            }
        }

        private void CheckUser()
        {
            //if (currentUser == null)
            //{
            //    throw new ArgumentException("User cannot be null");
            //}
        }

        public bool Login(string login, string pass)
        {
            currentUser = null;
            if (ConnectDB.Context.Users.FirstOrDefault(s => s.Login == login && s.Password == pass) != null)
            {
                currentUser = ConnectDB.Context.Users.First(s => s.Login == login);
            }
            return currentUser != null;
        }

        public UserDTO GetCurrentUser()
        {
            CheckUser();

            return new UserDTO(currentUser);
        }

        public bool CreateUser(UserDTO user)
        {
            CheckUser();

            if (ConnectDB.Context.Users.FirstOrDefault(s => s.Name == user.Name) == null)
            {
                ConnectDB.Context.Users.AddObject(new User { Login = user.Login, Name = user.Name, Password = user.Password });
                ConnectDB.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public void SendMessage(MessageDTO message)
        {
            CheckUser();

            if (message != null)
            {
                ConnectDB.Context.AddToMessages(message.ToDB());
            }
        }

        public List<MessageDTO> GetAllMessagesForUser(UserDTO user)
        {
            CheckUser();

            return ConnectDB.Context.Messages
                .Where(m => m.UserFrom == user.Id || m.UserTo == user.Id)
                .Select(m => new MessageDTO(m))
                .ToList();
        }

        public List<MessageDTO> GetAllMessagesForUserFromDate(UserDTO user, DateTime date)
        {
            CheckUser();

            return ConnectDB.Context.Messages
                .Where(m => (m.UserFrom == user.Id || m.UserTo == user.Id) && m.Date > date)
                .Select(m => new MessageDTO(m))
                .ToList();
        }
    }
}
