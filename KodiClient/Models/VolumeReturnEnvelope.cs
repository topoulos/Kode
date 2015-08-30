using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace KodiClient
{
    public class VolumeReturnEnvelope : IVolumeReturnEnvelope
    {
        public int Id { get; set; }
        public string Jsonrpc { get; set; }
        IVolumeResult IVolumeReturnEnvelope.Result
        {
            get { return Result; }
            set { Result = (VolumeResult)value;  }
        }
        public VolumeResult Result { get; set; }
    }
}
