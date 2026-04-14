using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Booking : INotifyPropertyChanged
    {

            private int id_;
            private string fullName_;
            private string phone_;
            private DateTime checkInDate_;
            private DateTime checkOutDate_;
            private int roomNumber_;

            [DisplayName("ФИО")]
            public string FullName
            {
                get { return fullName_; }
                set { fullName_ = value; OnPropertyChanged(nameof(FullName)); }
            }

            [DisplayName("Телефон")]
            public string Phone
            {
                get { return phone_; }
                set { phone_ = value; OnPropertyChanged(nameof(Phone)); }
            }

            [DisplayName("Дата заезда")]
            public DateTime CheckInDate
            {
                get { return checkInDate_; }
                set { checkInDate_ = value; OnPropertyChanged(nameof(CheckInDate)); }
            }

            [DisplayName("Дата выезда")]
            public DateTime CheckOutDate
            {
                get { return checkOutDate_; }
                set { checkOutDate_ = value; OnPropertyChanged(nameof(CheckOutDate)); }
            }

            [DisplayName("Номер")]
            public int RoomNumber
            {
                get { return roomNumber_; }
                set { roomNumber_ = value; OnPropertyChanged(nameof(RoomNumber)); }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        
    }
}
