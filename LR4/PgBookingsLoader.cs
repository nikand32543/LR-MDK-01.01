using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public class PgBookingsLoader
    {
        private BindingList<Booking> result_ = new BindingList<Booking>();
        private const string connectSetting = "Host=192.168.1.48;Username=st53-4;Password=534;Database=LR4_DB_Andrianov";

        public BindingList<Booking> Load()
        {
            try
            {
                result_.Clear();  

                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();
                    var sql = "SELECT full_name, phone, check_in_date, check_out_date, room_number FROM bookings ORDER BY check_in_date DESC";
                    using (var cmd = new NpgsqlCommand(sql, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking
                            {
                                FullName = reader.GetString(0),
                                Phone = reader.GetString(1),
                                CheckInDate = reader.GetDateTime(2),
                                CheckOutDate = reader.GetDateTime(3),
                                RoomNumber = reader.GetInt32(4)
                            };
                            result_.Add(booking);
                        }
                    }
                }
                return result_;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка загрузки: {exception.Message}");
                return null;
            }
        }

        public bool DeleteSelectedBooking(string fullName, DateTime checkInDate, int roomNumber)
        {
            try
            {
                bool result = false;
                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();
                    var sql = "DELETE FROM bookings WHERE full_name = @full_name AND check_in_date = @check_in_date AND room_number = @room_number";
                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@full_name", fullName);
                        cmd.Parameters.AddWithValue("@check_in_date", checkInDate);
                        cmd.Parameters.AddWithValue("@room_number", roomNumber);
                        int execute = cmd.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            result = true;
                        }
                    }
                }

                for (int i = 0; i < result_.Count; i++)
                {
                    if (result_[i].FullName == fullName &&
                        result_[i].CheckInDate == checkInDate &&
                        result_[i].RoomNumber == roomNumber)
                    {
                        result_.RemoveAt(i);
                        break;
                    }
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка удаления: {exception.Message}");
                return false;
            }
        }

        public bool ClearAllBookings()
        {
            try
            {
                bool result = false;
                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();
                    var sql = "DELETE FROM bookings";
                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        int execute = cmd.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            result = true;
                        }
                    }
                }
                result_.Clear();
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка очистки: {exception.Message}");
                return false;
            }
        }

        public bool AddBooking(Booking b)
        {
            try
            {
                // Проверка доступности номера
                if (!IsRoomAvailable(b.RoomNumber, b.CheckInDate, b.CheckOutDate))
                {
                    MessageBox.Show("Этот номер уже забронирован на выбранные даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool result = false;
                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();
                    var sql = @"INSERT INTO bookings (full_name, phone, check_in_date, check_out_date, room_number) 
                               VALUES(@full_name, @phone, @check_in_date, @check_out_date, @room_number)";

                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@full_name", b.FullName);
                        cmd.Parameters.AddWithValue("@phone", b.Phone);
                        cmd.Parameters.AddWithValue("@check_in_date", b.CheckInDate);
                        cmd.Parameters.AddWithValue("@check_out_date", b.CheckOutDate);
                        cmd.Parameters.AddWithValue("@room_number", b.RoomNumber);

                        int execute = cmd.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            result = true;
                            result_.Add(b);
                        }
                    }
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка добавления: {exception.Message}");
                return false;
            }
        }

        public bool EditBooking(Booking oldBooking, Booking newBooking)
        {
            try
            {
                if (oldBooking.RoomNumber != newBooking.RoomNumber ||
                    oldBooking.CheckInDate != newBooking.CheckInDate ||
                    oldBooking.CheckOutDate != newBooking.CheckOutDate)
                {
                    if (!IsRoomAvailable(newBooking.RoomNumber, newBooking.CheckInDate, newBooking.CheckOutDate))
                    {
                        MessageBox.Show("Этот номер уже забронирован на выбранные даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                bool result = false;
                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();
                    var sql = @"UPDATE bookings SET full_name = @new_full_name, phone = @new_phone, 
                               check_in_date = @new_check_in_date, check_out_date = @new_check_out_date, 
                               room_number = @new_room_number 
                               WHERE full_name = @old_full_name AND check_in_date = @old_check_in_date AND room_number = @old_room_number";

                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        // Новые значения
                        cmd.Parameters.AddWithValue("@new_full_name", newBooking.FullName);
                        cmd.Parameters.AddWithValue("@new_phone", newBooking.Phone);
                        cmd.Parameters.AddWithValue("@new_check_in_date", newBooking.CheckInDate);
                        cmd.Parameters.AddWithValue("@new_check_out_date", newBooking.CheckOutDate);
                        cmd.Parameters.AddWithValue("@new_room_number", newBooking.RoomNumber);

                        // Старые значения для поиска
                        cmd.Parameters.AddWithValue("@old_full_name", oldBooking.FullName);
                        cmd.Parameters.AddWithValue("@old_check_in_date", oldBooking.CheckInDate);
                        cmd.Parameters.AddWithValue("@old_room_number", oldBooking.RoomNumber);

                        int execute = cmd.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            result = true;
                            // Обновление в BindingList
                            for (int i = 0; i < result_.Count; i++)
                            {
                                if (result_[i].FullName == oldBooking.FullName &&
                                    result_[i].CheckInDate == oldBooking.CheckInDate &&
                                    result_[i].RoomNumber == oldBooking.RoomNumber)
                                {
                                    result_[i] = newBooking;
                                    break;
                                }
                            }
                        }
                    }
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка редактирования: {exception.Message}");
                return false;
            }
        }

        // Проверка доступности номера
        private bool IsRoomAvailable(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            using (var con = new NpgsqlConnection(connectSetting))
            {
                con.Open();
                string sql = @"SELECT COUNT(*) FROM bookings 
                              WHERE room_number = @room_number 
                              AND check_in_date < @check_out 
                              AND check_out_date > @check_in";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@room_number", roomNumber);
                    cmd.Parameters.AddWithValue("@check_in", checkIn);
                    cmd.Parameters.AddWithValue("@check_out", checkOut);

                    long count = (long)cmd.ExecuteScalar();
                    return count == 0;
                }
            }
        }
    }
}
