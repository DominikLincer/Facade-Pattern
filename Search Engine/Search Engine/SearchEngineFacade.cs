using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search_Engine.SearchEngineMechanisms;

namespace Search_Engine
{
    public class SearchEngineFacade
    {
        private readonly DataIndexers _dataIndexers;
        private readonly RetrievingDataMechanism _retrievingDataMechanism;
        private readonly GeneratingSnippetsMechanism _generatingSnippetsMechanism;
        private readonly PresentingResultsMechanism _presentingResultsMechanism;

        public SearchEngineFacade()
        {
            _dataIndexers = new DataIndexers();
            _retrievingDataMechanism = new RetrievingDataMechanism();
            _generatingSnippetsMechanism = new GeneratingSnippetsMechanism();
            _presentingResultsMechanism = new PresentingResultsMechanism();
        }

        public string GetSearchingResults(string query)
        {
            var indexes = _dataIndexers.GetIndexesOfStoredData(query);
            _retrievingDataMechanism.GetData(indexes);
            _generatingSnippetsMechanism.GenerateSnippets();
            _presentingResultsMechanism.PresentResult();
            return $"Searching results for query {query}: ...";
        }
    }
}
