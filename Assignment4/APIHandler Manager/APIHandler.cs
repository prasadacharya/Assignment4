using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Assignment4.Models;


namespace Assignment4.APIHandlerManager
{
    public class APIHandler
    {
        static string BASE_URL = "https://api.ers.usda.gov/data/arms";
        static string API_KEY = "v1iOVsEQOaQ5p77kQeMgB3L21otYsBewIypJNVEx";
       
        HttpClient httpClient;


        public APIHandler()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public States GetStates()
        {
            //  string NATIONAL_PARK_API_PATH = BASE_URL + "/parks?limit=20";
            string STATE_API_PATH = BASE_URL + "/state?";
            string statesData = "";

            States states = null;

            httpClient.BaseAddress = new Uri(STATE_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(STATE_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    statesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!statesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    states = JsonConvert.DeserializeObject<States>(statesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return states;
        }

        public SurveyDatas GetSurveyDatas()
        {
            //  string NATIONAL_PARK_API_PATH = BASE_URL + "/parks?limit=20";
            string STATE_API_PATH = BASE_URL + "/state?";
            string surveydataData = "";

            SurveyDatas surveydatas = null;

            httpClient.BaseAddress = new Uri(STATE_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(STATE_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    surveydataData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!surveydataData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    surveydatas = JsonConvert.DeserializeObject<SurveyDatas>(surveydataData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return surveydatas;
        }

        public Categories GetCategories()
        {
            string CATEGORY_API_PATH = BASE_URL + "/category?";
            string categoriesData = "";
            Categories categories = null;
            httpClient.BaseAddress = new Uri(CATEGORY_API_PATH);
            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(CATEGORY_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    categoriesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!categoriesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    categories = JsonConvert.DeserializeObject<Categories>(categoriesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return categories;
        }

        public Reports GetReports()
        {
            string REPORT_API_PATH = BASE_URL + "/report?";
            string reportsData = "";
            Reports reports = null;
            httpClient.BaseAddress = new Uri(REPORT_API_PATH);
            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(REPORT_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    reportsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!reportsData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    reports = JsonConvert.DeserializeObject<Reports>(reportsData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return reports;
        }
    }
}
