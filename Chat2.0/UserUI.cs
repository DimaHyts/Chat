using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat2._0.ServiceReference1;


namespace Client
{
    public class UserUI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserUI(UserDTO userDTO)
        {
            this.Id = userDTO.Id;
            this.Login = userDTO.Login;
            this.Name = userDTO.Name;
            this.Password = userDTO.Password;
        }

        public UserUI()
        {
 
        }

        public UserDTO UserToDTO()
        {
            return new UserDTO
            {
                Id = Id,
                Login = Login,
                Name = Name,
                Password = Password,
            };
        }

        public override string ToString()
        {
            return Login + " " + Id;
        }

    }
         
}
