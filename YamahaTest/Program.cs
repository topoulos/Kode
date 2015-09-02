using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kode.Interfaces;
using Kode.KodiClient;
using Kode.YamahaClient;

namespace YamahaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 100;
            var formattedVolume = string.Format("{0:0.0}", ((double)level / 10));
            Console.WriteLine(formattedVolume);
            Console.ReadKey();
            //var kodi= new Kodi();
            //kodi.VolumeToFull();

            //var receiver = new AVReceiver();
            //receiver.VolumeUp();
            //receiver.VolumeUp();
            //receiver.VolumeUp();
            //Console.ReadKey();
        }
    }
}
