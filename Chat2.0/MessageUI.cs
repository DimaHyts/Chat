using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat2._0.ServiceReference1;

namespace Client
{
    public class MessageIU
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserFromId { get; set; }
        public int UserToId { get; set; }
        public DateTime Date { get; set; }

        public MessageDTO toMessageDTO()
        {
            return new MessageDTO
            {
                Id=Id,
                Text=Text,
                UserFromId=UserFromId,
                UserToId=UserToId,
            };
        }
    }
}
