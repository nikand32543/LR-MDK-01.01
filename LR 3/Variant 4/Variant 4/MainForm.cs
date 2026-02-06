
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Variant_4
{
    public partial class MainForm: Form
    {
        Dictionary<string, List<Medicines>> menu = new Dictionary<string, List<Medicines>>();
        Dictionary<string, int> orders = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            menu.Add("От головной боли", new List<Medicines>()
            {  new Medicines("Ибупрофен-АКОС", 200.99, "..\\images\\овсяная каша.jpg", "Механизм действия:Ибупрофен подавляет синтез простагландинов — медиаторов воспаления и боли. Оказывает противовоспалительное, анальгезирующее и жаропонижающее действие.", new DateTime (2029, 1, 1)),
               new Medicines("Нурофен Форте", 99.99, "..\\images\\рисовая каша.jpg", "Механизм действия:Блокирует циклооксигеназу‑1 и циклооксигеназу‑2, снижая синтез простагландинов. Обладает выраженным обезболивающим и противовоспалительным эффектом.", new DateTime(2030, 2, 12)),
               new Medicines("Цитрамон П", 210.9, "..\\images\\манная каша.jpg", "Механизм действия:Ацетилсалициловая кислота — подавляет синтез простагландинов, обладает антиагрегантным действием", new DateTime(2028, 12, 1))
            }
            );
            menu.Add("От кашля", new List<Medicines>()
            {  new Medicines("АЦЦ Лонг", 199.9, "..\\images\\борщ.jpg", "Механизм действия: Препарат разрывает дисульфидные связи мукополисахаридов мокроты, что приводит к уменьшению её вязкости.", new DateTime(2030, 2, 12)),
               new Medicines("Мукалтин", 99.9, "..\\images\\рассольник.jpg", "Механизм действия: Мукалтин — смесь полисахаридов из травы алтея лекарственного. Препарат обладает отхаркивающими свойствами.", new DateTime (2029, 20, 1)),
               new Medicines("Гербион сироп первоцвета", 149.9, "..\\images\\окрошка.jpg", "Механизм действия: Препарат обладает отхаркивающим, противовоспалительным, противомикробным действием; способствует уменьшению вязкости мокроты и лучшему её отхождению.",new DateTime (2029, 2, 1))
            }
            );
            menu.Add("От аллергии", new List<Medicines>()
            {  new Medicines("Лоратадин", 149.9, "..\\images\\плов.jpg", "Механизм действия: блокирует H1-рецепторы, уменьшая симптомы аллергии. Отличается длительным действием (до 24 часов) и минимальным влиянием на центральную нервную систему.", new DateTime(2030, 2, 12)),
               new Medicines("Цетиризин", 99.9, "..\\images\\овощной салат.jpg", "Механизм действия: быстро блокирует H1-рецепторы, обеспечивая быстрое наступление эффекта. Действует в течение 24 часов.", new DateTime(2028, 12, 20)),
               new Medicines("Фексофенадин", 220.9, "..\\images\\картофельное пюре.jpg", "Механизм действия: относится к препаратам третьего поколения, обладает высокой селективностью, не проникает через гематоэнцефалический барьер, поэтому не вызывает сонливости.", new DateTime(2029, 4, 15))
            }
            );

            MedicinesListBox.DataSource = menu.Keys.ToList();
        }

            private void MedicinesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupComboBox.DataSource = menu[MedicinesListBox.SelectedItem.ToString()];
            GroupComboBox.DisplayMember = "Name";
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicines med = GroupComboBox.SelectedItem as Medicines;
            priceLabel.Text = med.Price + "  руб.";
            MedPictureBox.Load(med.Photo);
            DescriptionLabel.Text = dish.Description;
            QuantityTextBox.Text = "0";
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (orders.ContainsKey(CategoriesListBox.SelectedItem.ToString()))
            {
                orders[CategoriesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
                BasketRichTextBox.Clear();
                foreach (string key in orders.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
                }
            }
            else
            {
                orders.Add(CategoriesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
                }
            }
        }
    }
    }
}
