using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntitiesDTO;
using Entities;

namespace WCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Login(string login, string pass);

        [OperationContract]
        UserDTO GetCurrentUser();

        [OperationContract]
        bool CreateUser(UserDTO user);

        [OperationContract]
        void SendMessage(MessageDTO message);

        [OperationContract]
        List<MessageDTO> GetAllMessagesForUser(UserDTO user);

        [OperationContract]
        List<MessageDTO> GetAllMessagesForUserFromDate(UserDTO user, DateTime date);

        [OperationContract]
        List<UserDTO> GetOnlineUser();

        [OperationContract]
        List<UserDTO> GetAllUsers();

        [OperationContract]
        void LogOut();
    }
}
