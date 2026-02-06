using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm: Form
    {
        private FileUserStorage authorization_ = new FileUserStorage();
        private List<string> logins_ = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            List<User> allUsers = authorization_.Load();

            foreach (User u in allUsers)
            {
                logins_.Add(u.Login);
            }

            LoginComboBox.DataSource = logins_;
        }

        private void EnterButton_Click(object sender, System.EventArgs e)
        {
            List<User> identification = authorization_.Load();
            string login = LoginComboBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);
            
            if (Contains(identification, user))
            MessageBox.Show("Вы вошли");
        }
        private bool Contains(List<User> users, User user)
        {
            foreach(User u in users)
            {
                if (user.Login == u.Login && u.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
