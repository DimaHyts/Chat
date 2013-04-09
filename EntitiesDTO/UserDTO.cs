using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace EntitiesDTO
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

        public UserDTO(User user)
        {
            this.Id = user.Id;
            this.Name = user.Name;
            this.Login = user.Login;
            this.Password = user.Password;
        }

        public User ToDB()
        {
            return new User
            {
                Id = Id,
                Name = Name,
                Login = Login,
                Password = Password
            };
        }

    }
}
