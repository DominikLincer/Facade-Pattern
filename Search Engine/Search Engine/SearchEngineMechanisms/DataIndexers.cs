using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Engine.SearchEngineMechanisms
{
    public class DataIndexers
    {
        public int[] GetIndexesOfStoredData(string query)
        {
            Console.WriteLine($"{query} can be found at indexes: 1, 5, 8");
            return new[] {1, 5, 8};
        }
    }
}
