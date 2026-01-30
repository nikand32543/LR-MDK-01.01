
using System.Collections.Generic;
using System.Windows.Forms;

namespace Variant_4
{
    public partial class MainForm: Form
    {
        private List<List<Medicines>> allMedicines_ = new List<List<Medicines>>();
        private List<Medicines> natural_ = new List<Medicines>();
        private List<Medicines> synthetic_ = new List<Medicines>();
        private List<Medicines> mineral_ = new List<Medicines>();
        public MainForm()
        {
            InitializeComponent();
            natural_.Add(new Medicines(1000,"Тонзилгон","", "Комбинированный растительный препарат с антисептическим, противовоспалительным, иммуномодулирующим, противоотёчным и местным вяжущим действием."));
        }
    }
}
