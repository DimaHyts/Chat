using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using EntitiesDTO;


namespace WCF
{
    [ServiceBehavior (ConcurrencyMode=ConcurrencyMode.Multiple, InstanceContextMode=InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        public UserDTO currentUser;
        public List<UserDTO> OnlineUser=new List<UserDTO>();
        public Service1()
        {
        }

        private void CheckUser()
        {
            if (currentUser == null)
            {
                throw new ArgumentException("User cannot be null");
            }
        }

        public bool Login(string login, string pass)
        {
            if (ConnectDB.Context.Users.FirstOrDefault(s => s.Login == login && s.Password == pass) != null)
            {
                currentUser = new UserDTO(ConnectDB.Context.Users.First(s => s.Login == login));
                OnlineUser.Add(currentUser);
            }
            System.Console.WriteLine(currentUser.ToString());
            System.Console.ReadLine();
            return currentUser != null;
        }

        public UserDTO GetCurrentUser()
        {

            return currentUser;
        }

        public bool CreateUser(UserDTO user)
        {
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
                ConnectDB.Context.SaveChanges();
            }
        }

        public List<MessageDTO> GetAllMessagesForUser(UserDTO user)
        {
            CheckUser();

            return ConnectDB.Context.Messages
                .Where(m => m.UserFrom == user.Id || m.UserTo == user.Id).ToList()
                .Select(m => new MessageDTO(m))
                .ToList();
        }

        public List<MessageDTO> GetAllMessagesForUserFromDate(UserDTO user, DateTime date)
        {
            CheckUser();
              return ConnectDB.Context.Messages
                .Where(m => (m.UserFrom == user.Id || m.UserTo == user.Id) && m.Date > date).ToList()
                .Select(m => new MessageDTO
                    {
                        Date = m.Date,
                        Id= m.Id,
                        Text= m.Text,
                        UserFrom= new UserDTO (m.User_From),
                        UserTo= new UserDTO(m.User_To)
                    })
                .ToList();
          }

        public List<UserDTO> GetOnlineUser()
        {
            return OnlineUser;
        }

        public List<UserDTO> GetAllUsers()
        {
            return ConnectDB.Context.Users.Where(m => m.Login != currentUser.Login).ToList()
                                          .Select(m=> new UserDTO(m)).ToList();
        }

        public void LogOut()
        {
            OnlineUser.Remove(currentUser);
            currentUser = null;
        }
        
    }
}
