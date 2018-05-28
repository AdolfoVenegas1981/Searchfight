using SearchFight.Interfaces;

namespace SearchFight.Implementations.SearchEngines
{
    public class MSNSearch : SearchEngine
    {
        private const string apiKey = "dfdc2c99146c4e22b95412984e76ac40"; //dfdc2c99146c4e22b95412984e76ac40//7a1daa5ec1ab4086b8b2708e51d67ae1
        private const string customConfigId = "0";
		private const string uri = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search";

        public MSNSearch(IHttpHandler httpHandler) : base(httpHandler)
        {

        }

        protected override string GetUrl(string searchTerm)
        {
			return uri + "?q=" + searchTerm + "&customconfig=" + customConfigId; ;
        }

        protected override void AddRequestHeaders()
        {
           httpHandler.AddRequestHeader("Ocp-Apim-Subscription-Key", apiKey);
        }

        protected override long GetTotalResults(dynamic jObj)
        {
            return jObj["webPages"]["totalEstimatedMatches"];
        }
        public override string ToString()
        {
            return "MSN Search";
        }

    }
}
