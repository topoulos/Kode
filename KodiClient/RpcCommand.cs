using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Kode.Interfaces;
using Kode.KodiClient.Models;

namespace Kode.KodiClient
{
    public class RpcCommand : IRpcCommand
    {
        private string ipAddress;
        public IVolumeReturnEnvelope VolumeReturnMessage { get; set; }
        public RpcCommand(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }
        public void SendCommand(string command)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ipAddress + @"/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = client.GetAsync(command).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        VolumeReturnMessage = response.Content.ReadAsAsync<VolumeReturnEnvelope>().Result;
                    }

                }
                catch (Exception ex)
                {

                    System.Diagnostics.Debug.Print(ex.Message);
                }            }
        }
    }
}