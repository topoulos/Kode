﻿namespace Kode.KodiClient.Models
{
    public class VolumeReturnEnvelope : IVolumeReturnEnvelope
    {
        public int Id { get; set; }
        public string Jsonrpc { get; set; }

        IVolumeResult IVolumeReturnEnvelope.Result
        {
            get { return Result; }
            set { Result = (VolumeResult)value; }
        }

        public VolumeResult Result { get; set; }
    }
}