using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class RegistrationForm: Form
    {
        FileUserStorage registration_ = new FileUserStorage();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            string log = LogTextBox.Text;
            string passw = PasswTextBox.Text;
            
        }
    }
}
