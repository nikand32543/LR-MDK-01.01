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
    public partial class AddBooking : Form
    {
        private PgBookingsLoader loader_;
        private bool editMode_ = false;
        private Booking oldBooking_;

        public AddBooking(PgBookingsLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        public void SetBooking(Booking b)
        {
            oldBooking_ = b;
            txtFullName.Text = b.FullName;
            txtPhone.Text = b.Phone;
            dtpCheckIn.Value = b.CheckInDate;
            dtpCheckOut.Value = b.CheckOutDate;
            numRoomNumber.Value = b.RoomNumber;
            editMode_ = true;
            Text = "Редактирование";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Введите телефон!");
                return;
            }
            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                MessageBox.Show("Дата выезда позже даты заезда!");
                return;
            }

            Booking newBooking = new Booking
            {
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                CheckInDate = dtpCheckIn.Value.Date,
                CheckOutDate = dtpCheckOut.Value.Date,
                RoomNumber = (int)numRoomNumber.Value
            };

            if (editMode_)
                loader_.EditBooking(oldBooking_, newBooking);
            else
                loader_.AddBooking(newBooking);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
