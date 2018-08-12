using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Engine.SearchEngineMechanisms
{
    public class RetrievingDataMechanism
    {
        public void GetData(int[] indexes)
        {
            Console.Write("Downloading web pages with indexes: ");
            foreach (var index in indexes)
            {
                Console.Write(index + ", ");
            }

            Console.WriteLine();
        }
    }
}
