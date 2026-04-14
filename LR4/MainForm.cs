using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class MainForm : Form
    {
        PgBookingsLoader loader = new PgBookingsLoader();


        public MainForm()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<Booking> booking = loader.Load();
            dataGridView.DataSource = booking;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView.SelectedRows[0];
            Booking user = row.DataBoundItem as Booking;
            loader.DeleteSelectedBooking(user.Login);

        }

        

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking(loader);
            AddBooking.Show();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User selectedUser = row.DataBoundItem as User;
            AddUsers editUser = new AddUsers(loader);
            editUser.SetUser(selectedUser);
            editUser.Show();
        }
    }
}
