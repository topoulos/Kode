using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace KodiClient
{
    public class RpcCommand : IRpcCommand
    {
        public IVolumeReturnEnvelope VolumeReturnMessage { get; set; }

        public void SendCommand(string command)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.0.222:8080/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(command).Result;
                if (response.IsSuccessStatusCode)
                {
                    VolumeReturnMessage = response.Content.ReadAsAsync<VolumeReturnEnvelope>().Result;
                }
            }
        }
    }
}