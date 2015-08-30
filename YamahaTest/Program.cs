﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using KodiClient;
using YamahaClient;

namespace YamahaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kodi= new Kodi();
            kodi.VolumeToFull();
            
            var receiver = new AVReceiver();
            receiver.VolumeUp();
            receiver.VolumeUp();
            receiver.VolumeUp();
            Console.ReadKey();
        }
    }
}