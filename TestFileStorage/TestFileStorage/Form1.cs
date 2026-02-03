using System.Collections.Generic;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm: Form
    {
        private FileUserStorage authorization = new FileUserStorage();
        public MainForm()
        {
            InitializeComponent();

        }

        private void EnterButton_Click(object sender, System.EventArgs e)
        {
            List<User> identification = authorization.Load();
            string login = LoginTextBox.Text;
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
