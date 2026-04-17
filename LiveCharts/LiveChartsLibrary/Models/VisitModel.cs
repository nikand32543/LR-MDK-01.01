using System.Collections.Generic;
using System.Linq;

namespace LiveChartsLibrary.Modesl
{
    public class VisitModel
    {
        private Dictionary<Section, List<Visit>> visitBySection_ = new Dictionary<Section, List<Visit>>();

        public void AddVisit(Section section, List<Visit> visit)
        {
            if (visitBySection_.ContainsKey(section))
            {
                visitBySection_[section].AddRange(visit);
            }
            else
            {
                visitBySection_.Add(section, visit);
            }
        }

        public List<Visit> LoadVisitsForSection(string sectionName)
        {
            List<Section> allItems = visitBySection_.Keys.ToList();
            Section targetSection = allItems.Find(section => section.Name == sectionName);
            if (targetSection != null)
            {
                return visitBySection_[targetSection];
            }

            return new List<Visit>();
        }

        public bool Load()
        {
            AddVisit(new Section { Name = "Футбол", Price = 300 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 10 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 20 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 30 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 40 },
                    new Visit {Date = new System.DateTime(2026, 2, 5), Count = 50 },
                });

            AddVisit(new Section { Name = "Теннис", Price = 250 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 2 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 3 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 4 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 1 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 15 },
               });
            AddVisit(new Section { Name = "Баскетбол", Price = 400 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 99 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 1 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 21 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 25 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 55 },
               });
            AddVisit(new Section { Name = "Плавание", Price = 150 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 15 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 15 },
               });

            return true;
        }
        public List<Section> GetAllSection()
        {
            return visitBySection_.Keys.ToList();
        }
        public Section GetSection(string sectionName)
        {
            foreach (KeyValuePair<Section, List<Visit>> keyValue in visitBySection_)
            {
                Section section = keyValue.Key;
                if (section.Name == sectionName)
                {
                    return section;
                }
            }

            return null;
        }
        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Section, List<Visit>> keyValue in visitBySection_)
            {
                Section section = keyValue.Key;
                result += keyValue.Value.Sum(visit => visit.Count * section.Price);
            }

            return result;
        }
    }
}
