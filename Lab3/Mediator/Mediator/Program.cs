using Mediator.Mediators;
using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();

            SimpleUser user1 = new SimpleUser(chat, "Marin1");
            SimpleUser user2 = new SimpleUser(chat, "Vlad2");
            SimpleUser user3 = new SimpleUser(chat, "Razvan3");


            chat.AddSimpleUserToChat(user1);
            chat.AddSimpleUserToChat(user2);
            chat.AddSimpleUserToChat(user3);


            user1.SendMessageAll("Salutare la toti");
            user2.SendMessageTo("Salut Vasea, cum meciul de fotbal?", "Razvan3");
            user3.SendMessageTo("Salutare Valera, mi-a placut foarte mult", "Vlad2");
            user3.SendMessageTo("Salut Nicolae, cum lab5 la testare?", "Nicolae4");
        }
    }
}
