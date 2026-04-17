using LiveChartsLibrary.Analysis;
using LiveChartsLibrary.Modesl;
using LiveChartsLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLibrary.Presenters
{
    public class VisitsPresenter
    {
        private VisitModel model_ = new VisitModel();
        private List<IVisitView> views_;
        public VisitsPresenter(List<IVisitView> views)
        {
            views_ = views;

            model_.Load();
        }
        public void ShowVisitsBySection(string sectionName)
        {
            List<Visit> visits = model_.LoadVisitsForSection(sectionName);
            foreach (IVisitView view in views_)
            {
                view.Show(visits);
            }
        }
        public List<Section> GetAllSections()
        {
            return model_.GetAllSection();
        }
        public double GetProfitPercentByItem(Section selectedSection)
        {
            double result = ProfitAnalyzer.CalculateProfitPercentBySection(selectedSection.Name,
                                                               model_);
            return Math.Round(result, 2);
        }
    }
}
