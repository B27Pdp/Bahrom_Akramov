using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Chat_App
{
    internal class ContactUser
    {
        public List<User> users = new List<User>();
        User user1;
        User u;

        //public ContactUser()
        //{
        //    users = new List<User>();
        //}

        public void defaultUsers()
        {
            users.Add(new User("Halim", "15"));
            users.Add(new User("Salim", "12"));
            users.Add(new User("Ali", "10"));
            users.Add(new User("Vali", "20"));
        }

        public void addNewUser(string name, string phone)
        {
            User user = new(name, phone);
            users.Add(user);
            user1 = user;
        }

        public int enterUser(string phone)
        {
            var userPhone = users.Find(x => x.PhoneNumber.Equals(phone));
            if (userPhone != null)
            {
                return 1;
            }
            return -1;
        }

        public int chatting(string name)
        {
            var friend = users.Find(x => x.Name.ToLower() == name.ToLower());
            u = friend;
            if (friend == null)
            {
                return -1;
            }
            else
            {
                user1.sendSMSMassage += friend.enterMassage;
                friend.sendSMSMassage += user1.enterMassage;
                user1.sendMassage();
                friend.showMassages();
                user1.sendSMSMassage -= friend.enterMassage;
                friend.sendSMSMassage -= user1.enterMassage;
                return 1;
            }
        }
        public void showM()
        {
            u.showMassages();
        }
    }
}
