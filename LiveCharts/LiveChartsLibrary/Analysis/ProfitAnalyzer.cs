using LiveChartsLibrary.Modesl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLibrary.Analysis
{
    public class ProfitAnalyzer
    {
        public static double CalculateProfitPercentBySection(string sectionName, VisitModel model)
        {
            List<Visit> sectionVisits = model.LoadVisitsForSection(sectionName);
            Section targetSection = model.GetSection(sectionName);
            if (targetSection == null)
            {
                return 0.0;
            }
            double sectionTotal = sectionVisits.Sum(visit => visit.Count * targetSection.Price);

            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return sectionTotal / total * 100.0;
        }
    }
}
