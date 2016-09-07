﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Community.Uwp
{
    public static class CustomHttpClient
    {

        public static HttpClient GetClient()
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:32162/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
        public static HttpClient GetClient(string requestedVersion = null)
        {

            HttpClient client = new HttpClient();



            client.BaseAddress = new Uri("http://localhost:32162/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if (requestedVersion != null)
            {

                client.DefaultRequestHeaders.Add("api-version", requestedVersion);




            }

            return client;
        }
      
    }
}