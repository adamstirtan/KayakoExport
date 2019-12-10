using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using CsvHelper;

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

        private const string UserName = "";
        private const string Password = "";
        private const int PageSize = 100;

        public async Task StartAsync()
        {
            List<Case> exportedCases = new List<Case>();
            List<Conversation> exportedConversations = new List<Conversation>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{UserName}:{Password}")));

                var response = await client.GetAsync($"{CasesUrl}?limit=1");

                var casesResponse = JsonConvert.DeserializeObject<CasesResponse>(
                    await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                var offset = 0;
                var totalPages = (int)Math.Ceiling(casesResponse.TotalCount / (decimal)PageSize);

                Console.WriteLine("Downloading cases");

                for (var i = 0; i < totalPages; i++, offset += PageSize)
                {
                    Console.Write(".");

                    response = await client.GetAsync($"{CasesUrl}?offset={offset}&limit={PageSize}");

                    casesResponse = JsonConvert.DeserializeObject<CasesResponse>(
                        await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                    exportedCases.AddRange(casesResponse.Cases);
                }

                Console.WriteLine(" Done!");

                response = await client.GetAsync($"{ConversationsUrl}?limit=1");

                var conversationsResponse = JsonConvert.DeserializeObject<ConversationsResponse>(
                    await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                offset = 0;
                totalPages = (int)Math.Ceiling(conversationsResponse.TotalCount / (decimal)PageSize);

                Console.WriteLine("Downloading conversations");

                for (var i = 0; i < totalPages; i++, offset += PageSize)
                {
                    Console.Write(".");

                    response = await client.GetAsync($"{ConversationsUrl}?offset={offset}&limit={PageSize}");

                    conversationsResponse = JsonConvert.DeserializeObject<ConversationsResponse>(
                        await response.Content.ReadAsStringAsync().ConfigureAwait(false));

                    exportedConversations.AddRange(conversationsResponse.Conversations);
                }

                Console.WriteLine(" Done!");
            }

            // Dump the data to a string
            // Copy and paste to Excel!
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.AutoMap<Case>();

                csvWriter.WriteHeader<Case>();
                csvWriter.WriteRecords(exportedCases);

                csvWriter.Flush();

                var result = Encoding.UTF8.GetString(memoryStream.ToArray());

                Console.WriteLine(result);
            }

            // Do it again for conversations
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.AutoMap<Conversation>();

                csvWriter.WriteHeader<Conversation>();
                csvWriter.WriteRecords(exportedConversations);

                csvWriter.Flush();

                var result = Encoding.UTF8.GetString(memoryStream.ToArray());

                Console.WriteLine(result);
            }
        }
    }
}