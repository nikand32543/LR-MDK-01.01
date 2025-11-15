using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Диски
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Disk>> diskDirectories = new Dictionary<string, List<Disk>>();
            
            List<Disk> diskC = new List<Disk>();
            diskC.Add(new Disk("Документы", 2025, 150));
            diskC.Add(new Disk("Загрузки", 2025, 300));
        }
    }
}
