using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartLibrary.Models
{
    public class CinemaModel
    {
        private Dictionary<Film, List<TicketSale>> salesByFilm_ = new Dictionary<Film, List<TicketSale>>();

        public void AddSales(Film film, List<TicketSale> sales)
        {
            if (salesByFilm_.ContainsKey(film))
            {
                salesByFilm_[film].AddRange(sales);
            }
            else
            {
                salesByFilm_.Add(film, sales);
            }
        }
        public List<TicketSale> LoadSalesForFilm(string FilmName)
        {
            List<Film> allItems = salesByFilm_.Keys.ToList();
            Film targetFilm = allFilms.Find(film => film.Name == FilmName);
            if (targetFilm != null)
            {
                return salesByFilm_[targetFilm];
            }

            return new List<TicketSale>();
        }
        public bool Load()
        {
            AddSales(new Film { Name = "Аватар", Price = 1200 },
                new List<TicketSale>() {
                new TicketSale {Data = new DateTime(2026, 3, 9), TicketCount = 120},

                });
        }
    }
}
