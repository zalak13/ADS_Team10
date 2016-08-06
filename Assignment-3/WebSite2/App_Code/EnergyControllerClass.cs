﻿// This code requires the Nuget package Microsoft.AspNet.WebApi.Client to be installed.
// Instructions for doing this in Visual Studio:
// Tools -> Nuget Package Manager -> Package Manager Console
// Install-Package Microsoft.AspNet.WebApi.Client

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Website2
{

    public class StringTable
    {
        public string[] ColumnNames { get; set; }
        public string[,] Values { get; set; }
    }

  /*  class EnergyAnalyticsClass
    {
        
        public static string PredictPowerGeneration(String Inputs)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() { 
                        { 
                            "input1", 
                            new StringTable() 
                            {
                                ColumnNames = new string[] {"Plant Id", "Combined Heat And Power Plant", "Plant State", "Sector Name", "Reported Fuel Type Code", "AER Fuel Type Code", "Netgen_January", "Netgen_February", "Netgen_March", "Netgen_April", "Netgen_May", "Netgen_June", "Netgen_July", "Netgen_August", "Netgen_September", "Netgen_October", "Netgen_November", "Netgen_December", "Total Fuel Consumption Quantity", "Total Fuel Consumption MMBtu"},
                                Values = new string[,] {  { "0", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "0", "0" },  { "0", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "value", "0", "0" },  }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "abc123"; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/65817a10f4a4452db8059313c8182a68/services/9b3023fe58114cdf888c4389e3edeec1/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }
    }*/
}