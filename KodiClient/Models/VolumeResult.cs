using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace KodiClient
{
    public class VolumeResult : IVolumeResult
    {
        public int Volume { get; set; }
    }
}
