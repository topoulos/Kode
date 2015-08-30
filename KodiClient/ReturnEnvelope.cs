using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodiClient
{
    public class VolumeReturnEnvelope
    {
        public int Id { get; set; }
        public string Jsonrpc { get; set; }
        public VolumeResult Result { get; set; }
    }
    public class VolumeResult
    {
        public int Volume { get; set; }
    }
}
