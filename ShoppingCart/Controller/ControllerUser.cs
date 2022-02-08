using ShoppingCart.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Controller
{
    internal class ControllerUser
    {
        private List<User> users;

        public ControllerUser()
        {
            users = new List<User>();
            ReadUserTxt();
        }
        //find user index
        public int UserIndex(int idUser) 
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == idUser)
                {
                    return i;
                }
            }
            return -1;
        }
        public void AddUser(User userToAdd)
        {
            if (!users.Contains(userToAdd))
            {
                users.Add(userToAdd);
                MessageBox.Show("User added! ");
                SaveToFileUserTxt();
            }
        }

        public User ReturnUser(string name, string password, bool isAdmin)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == name
                && users[i].Password == password
                && users[i].IsAdmin == isAdmin)
                {
                    return users[i];
                }
            }
            return null;
        }

        public string ToStringObjectUserFile()
        {
            string userDataComplete = "";
            for (int i = 0; i < users.Count; i++)
            {
                userDataComplete += users[i].toSaveUser() + "\n";
            }
            return userDataComplete;
        }
        public void ReadUserTxt()
        {
            StreamReader read = new StreamReader(@"../../../Files/Users.txt");
            string line = "";
            line = read.ReadLine();
            while (line != null && line != "")
            {
                string[] formattedUser = line.Split(",");
                int id = int.Parse(formattedUser[0]);
                string userName = formattedUser[1];
                string password = formattedUser[2];
                bool isAdmin = bool.Parse(formattedUser[3]);   
                User userToAdd = new User(id, userName, password, isAdmin);
                users.Add((userToAdd));
                line = read.ReadLine();
            }
            //close file
            read.Close();
        }
        public void SaveToFileUserTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/Users.txt");
            write.WriteLine(ToStringObjectUserFile());
            write.Close();
        }

        public bool IsUserAdmin(User user)
        {
            if (user.IsAdmin == true)
            {
                return true;
            }
            return false;
        }

        public void PrintUsers(ListView listUsers)
        {
            listUsers.Clear();
            listUsers.Columns.Add("Id", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Password", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Is admin ", 100, HorizontalAlignment.Left);
            for (int i = 0; i < users.Count; i++)
            {
                ListViewItem line = new ListViewItem();
                line.Text = users[i].ID.ToString();
                line.SubItems.Add(users[i].UserName);
                line.SubItems.Add(users[i].Password);
                line.SubItems.Add(users[i].IsAdmin.ToString());
                listUsers.Items.Add(line);
            }

        }


    }
}
