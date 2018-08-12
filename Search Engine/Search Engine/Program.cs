using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchingEngineFacade = new SearchEngineFacade();
            var searchingResults = searchingEngineFacade.GetSearchingResults("My query");
            Console.WriteLine(searchingResults);

            Console.ReadKey();
        }
    }
}
