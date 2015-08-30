using Interfaces;
namespace KodiClient
{
    public class KodiApplicationCommand : IKodiApplicationCommand
    {
        private string setVolumeFull = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 100 } }";
        private string setVolumeMute = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 0 } }";
        private string setVolumeHalf = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 50 } }";
        private string getVolume     = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.GetProperties"",""params"": { ""properties"": [""volume""]}, ""id"":1 }";

        public string SetVolumeFull
        {
            get
            {
                return setVolumeFull;
            }

            set
            {
                setVolumeFull = value;
            }
        }

        public string SetVolumeMute
        {
            get
            {
                return setVolumeMute;
            }

            set
            {
                setVolumeMute = value;
            }
        }

        public string SetVolumeHalf
        {
            get
            {
                return setVolumeHalf;
            }

            set
            {
                setVolumeHalf = value;
            }
        }

        public string GetVolume
        {
            get
            {
                return getVolume;
            }

            set
            {
                getVolume = value;
            }
        }

        public string SetVolumeAt(int level)
        {
            return @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": " + level.ToString() + " } }";
        }
    }
}