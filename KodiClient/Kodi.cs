using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace KodiClient
{
    public class Kodi : IKodi
    {
        private Input input;
        private Application application;
        private VolumeReturnEnvelope volumenReturnMessage;

        public Kodi()
        {
            input = new Input();
            application = new Application();
        }
        public void VolumeToHalf()
        {
            SendCommand(application.SetVolumeHalf);
        }
        public void VolumeToFull()
        {
            SendCommand(application.SetVolumeFull);
        }
        public void Up()
        {
            SendCommand(input.Up);
        }
        public void Down()
        {
            SendCommand(input.Down);
        }
        public void Left()
        {
            SendCommand(input.Left);
        }
        public void Right()
        {
            SendCommand(input.Right);
        }
        public void Back()
        {
            SendCommand(input.Back);
        }
        public void Select()
        {
            SendCommand(input.Select);
        }

        public void VolumeToMute()
        {
            SendCommand(application.SetVolumeMute);
        }
        public int GetVolumeLevel()
        {
            SendCommand(application.GetVolume);
            return volumenReturnMessage.Result.Volume;
        }
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
                    volumenReturnMessage =  response.Content.ReadAsAsync<VolumeReturnEnvelope>().Result;
                }
            }
        }

        public void SetVolume(int level)
        {
            SendCommand(application.SetVolumeAt(level));
        }

        public void Home()
        {
            SendCommand(input.Home);
        }
    }
}
