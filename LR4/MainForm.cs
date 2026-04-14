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
            LoadBookings();

            CreateButton.Click += CreateButton_Click;
            Edit.Click += Edit_Click;
            deleteButton.Click += deleteButton_Click;
        }

        private void LoadBookings()
        {
            dataGridView.DataSource = loader.Load();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись!");
                return;
            }

            Booking booking = dataGridView.SelectedRows[0].DataBoundItem as Booking;

            if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loader.DeleteSelectedBooking(booking.FullName, booking.CheckInDate, booking.RoomNumber);
                LoadBookings();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking(loader);
            addBooking.ShowDialog();
            LoadBookings();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись!");
                return;
            }

            Booking selectedBooking = dataGridView.SelectedRows[0].DataBoundItem as Booking;
            AddBooking editBooking = new AddBooking(loader);
            editBooking.SetBooking(selectedBooking);
            editBooking.ShowDialog();
            LoadBookings();
        }
    }
}
