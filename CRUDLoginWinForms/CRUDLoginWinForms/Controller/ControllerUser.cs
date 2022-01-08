using CRUDWithLoginExample.Classes;

namespace CRUDWithLoginExample.Controller
{
    internal class ControllerUser
    {
            private List<User> users;
            public ControllerUser()
            {
                users = new List<User>();
                readUserTxt();
            }
            //Find the user Index
            public int userIndex(string user)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].getUser().Equals(user))
                    {
                        return i;
                    }
                }
                return -1;
            }
            public bool Add(User user)
            {
                int index = userIndex(user.getUser());
                if (index == -1)
                {
                    this.users.Add(user);
                    Console.WriteLine("User added ");
                    saveToFileUserTxt();
                    return true;
                }
                MessageBox.Show("User exists ");
                return false;
            }

            //update User, pw and isAdmin
            //it searches for the old user, it searches and check if the password match also
            public bool updateUser(User user, string newName, string newPassword)
            {
                int index = userIndex(user.getUser());
                if (index != -1) //check if the user does not exists in the list 
                {
                    if (users[index].getPassword() == user.getPassword())
                    {
                        users[index].setUser(newName);
                        users[index].setPassword(newPassword);
                        users[index].setIsAdmin(user.getIsAdmin());
                        saveToFileUserTxt();
                        return true;
                    }
                    MessageBox.Show("Password not match for the user");
                }
                MessageBox.Show("User not found.");

                return false;
            }

            //delete user
            public bool DeleteUser(string user)
            {
                int indexOfUser = userIndex(user);
                if (indexOfUser != -1)
                {
                    MessageBox.Show("User " + users[indexOfUser].getUser() + " deleted");
                    this.users.RemoveAt(indexOfUser);
                    saveToFileUserTxt();
                    return true;
                }
                MessageBox.Show("User not found");
                return false;
            }
            public string toStringObjectUserFile()
            {
                string userDataComplete = "";
                for (int i = 0; i < users.Count; i++)
                {
                    userDataComplete += users[i].toSaveUser() + "\n";
                }
                return userDataComplete;
            }
            //reads from file
            public void readUserTxt()
            {
                StreamReader read = new StreamReader(@"../../../Files/Users.txt");
                String line = "";
                line = read.ReadLine();

                while (line != "" && line != null)
                {
                    string[] formattedUser = line.Split(",");
                    string user = formattedUser[0];
                    string password = formattedUser[1];
                    bool isAdmin = bool.Parse(formattedUser[2]);
                    User userToAdd = new User(user, password, isAdmin);
                    users.Add(userToAdd);
                    line = read.ReadLine();
                }
                read.Close();
            }

            //Save to file
            public void saveToFileUserTxt()
            {
                StreamWriter write = new StreamWriter(@"../../../Files/Users.txt");
                write.WriteLine(this.toStringObjectUserFile());
                write.Close();
            }

            //Function which checks if the object User has checked/is Admin
            public bool isUserAdmin(User userRole)

            {
                if (userRole.getIsAdmin() == true)
                {
                    return true;
                }
                return false;
            }

            public User returnUser(string nume, string password, bool adminRole)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].getUser().Equals(nume)
                     && users[i].getPassword().Equals(password)
                     && users[i].getIsAdmin() == adminRole)
                    {
                        return users[i];
                    }
                }
                return null;
            }

            public void AfisareUsers(ListView listUsers)
            {
                listUsers.Clear();
                listUsers.Columns.Add("User", 100, HorizontalAlignment.Left);
                listUsers.Columns.Add("Password", 100, HorizontalAlignment.Left);
                listUsers.Columns.Add("Is Admin", 100, HorizontalAlignment.Left);
                for (int i = 0; i < users.Count; i++)
                {
                    ListViewItem linie = new ListViewItem();
                    linie.Text = users[i].getUser();
                    linie.SubItems.Add(users[i].getPassword());
                    linie.SubItems.Add(users[i].getIsAdmin().ToString());
                    listUsers.Items.Add(linie);
                }
            }

            public void ClearUsers(ListView listUsers)
            {
                listUsers.Clear();
            }
    }
}
