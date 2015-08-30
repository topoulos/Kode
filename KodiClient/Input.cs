using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KodiClient
{
    public class Input
    {
        public string Back =   @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Back"" }";
        public string Down =   @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Down"" }";
        public string Up =     @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Up"" }";
        public string Left =   @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Left"" }";
        public string Home =   @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Home"" }";
        public string Right =  @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Right"" }";
        public string Select = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Select"" }";
        public string SendText(string text)
        {
            return @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""text"": " + text + @",""done"": true } }";
        }
    }
    public class Application
    {
        public string SetVolumeFull = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 100 } }";
        public string SetVolumeMute = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 0 } }";
        public string SetVolumeHalf = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": 50 } }";
        //{"jsonrpc": "2.0", "method": "Application.GetProperties", "params": {"properties": ["volume"]}, "id": 1}
        public string GetVolume =     @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.GetProperties"",""params"": { ""properties"": [""volume""]}, ""id"":1 }";
        public string SetVolumeAt(int level)
        {
            return @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""volume"": " + level.ToString() + " } }";
        }
    }
}


