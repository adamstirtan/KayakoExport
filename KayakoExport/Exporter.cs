using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using KayakoExport.Models;

namespace KayakoExport
{
    internal class Exporter
    {
        private const string CasesUrl =
            "https://fernsoftware.kayako.com/api/v1/cases.json";

        private const string ConversationsUrl =
            "https://fernsoftware.kayako.com/api/v1/conversations.json";

        private const string UserName = "!";
        private const string Password = "!";
        private const int PageSize = 100;

        public async Task StartAsync()
        {
            List<Case> exportedCases = new List<Case>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{UserName}:{Password}")));

                var response = await client.GetAsync($"{CasesUrl}?limit=1");

                var casesResponse = JsonConvert.DeserializeObject<CasesResponse>(
                    await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                var totalPages = (int)Math.Ceiling(casesResponse.TotalCount / (decimal)PageSize);

                for (var offset = 0; offset <= totalPages; offset += PageSize)
                {
                    response = await client.GetAsync($"{CasesUrl}?offset={offset}&limit={PageSize}");

                    casesResponse = JsonConvert.DeserializeObject<CasesResponse>(
                        await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                    exportedCases.AddRange(casesResponse.Cases);
                }
            }

            // Write exportedCases to file
        }
    }
}