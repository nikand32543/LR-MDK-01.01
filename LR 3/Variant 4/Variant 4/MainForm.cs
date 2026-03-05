
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Variant_4
{
    public partial class MainForm: Form
    {
        Dictionary<string, List<Medicines>> group = new Dictionary<string, List<Medicines>>();
        Dictionary<string, int> orders = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            group.Add("От головной боли", new List<Medicines>()
            {  new Medicines("Ибупрофен-АКОС", 200.99, ".\\картинки\\Ибупрофен.jpg", "Механизм действия:Ибупрофен подавляет синтез простагландинов — медиаторов воспаления и боли. Оказывает противовоспалительное, анальгезирующее и жаропонижающее действие.", new DateTime (2029, 1, 1), "Звезда", "Renewal"),
               new Medicines("Нурофен Форте", 99.99, ".\\картинки\\Нурофен.jpg", "Механизм действия:Блокирует циклооксигеназу‑1 и циклооксигеназу‑2, снижая синтез простагландинов. Обладает выраженным обезболивающим и противовоспалительным эффектом.", new DateTime(2030, 2, 12), "Звезда", "Renewal"),
               new Medicines("Цитрамон П", 210.9, ".\\картинки\\Цитрамон.jpg", "Механизм действия:Ацетилсалициловая кислота — подавляет синтез простагландинов, обладает антиагрегантным действием", new DateTime(2028, 12, 1), "Звезда", "Renewal")
            }
            );
            group.Add("От кашля", new List<Medicines>()
            {  new Medicines("АЦЦ Лонг", 199.9, ".\\картинки\\АЦЦ.jpg", "Механизм действия: Препарат разрывает дисульфидные связи мукополисахаридов мокроты, что приводит к уменьшению её вязкости.", new DateTime(2030, 2, 12), "Звезда", "Renewal"),
               new Medicines("Мукалтин", 99.9, ".\\картинки\\Мукалтин.jpg", "Механизм действия: Мукалтин — смесь полисахаридов из травы алтея лекарственного. Препарат обладает отхаркивающими свойствами.", new DateTime (2029, 11, 1), "Звезда", "Renewal"),
               new Medicines("Гербион сироп первоцвета", 149.9, ".\\картинки\\Гербион.jpg", "Механизм действия: Препарат обладает отхаркивающим, противовоспалительным, противомикробным действием; способствует уменьшению вязкости мокроты и лучшему её отхождению.",new DateTime (2029, 2, 1), "Звезда", "Renewal")
            }
            );
            group.Add("От аллергии", new List<Medicines>()
            {  new Medicines("Лоратадин", 149.9, ".\\картинки\\Лоратадин.jpg", "Механизм действия: блокирует H1-рецепторы, уменьшая симптомы аллергии. Отличается длительным действием (до 24 часов) и минимальным влиянием на центральную нервную систему.", new DateTime(2030, 2, 12), "Звезда", "Renewal"),
               new Medicines("Цетиризин", 99.9, ".\\картинки\\Цетиризин.jpg", "Механизм действия: быстро блокирует H1-рецепторы, обеспечивая быстрое наступление эффекта. Действует в течение 24 часов.", new DateTime(2028, 12, 20), "Звезда", "Renewal"),
               new Medicines("Фексофенадин", 220.9, ".\\картинки\\Фексофенадин.jpg", "Механизм действия: относится к препаратам третьего поколения, обладает высокой селективностью, не проникает через гематоэнцефалический барьер, поэтому не вызывает сонливости.", new DateTime(2029, 4, 15), "Звезда", "Renewal")
            }
            );

            MedicinesListBox.DataSource = group.Keys.ToList();
        }

            private void MedicinesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupComboBox.DataSource = group[MedicinesListBox.SelectedItem.ToString()];
            GroupComboBox.DisplayMember = "Name";
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicines med = GroupComboBox.SelectedItem as Medicines;
            priceLabel.Text = med.Price + "  руб.";
            MedPictureBox.Load(med.Photo);
            DescriptionLabel.Text = med.Description;
            QuantityTextBox.Text = "0";
            ExpirationLabel.Text = med.Date;
            SuppLabel.Text = med.Supplier;
            ManufacLabel.Text = med.Manufacturer;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (orders.ContainsKey(MedicinesListBox.SelectedItem.ToString()))
            {
                orders[MedicinesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
                BasketRichTextBox.Clear();
                foreach (string key in orders.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
                }
            }
            else
            {
                orders.Add(MedicinesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
                }
            }
        }
    }
    
}
