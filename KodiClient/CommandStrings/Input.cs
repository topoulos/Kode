using System;
using Kode.Interfaces;
namespace Kode.KodiClient.CommandStrings
{
    public class KodiInputCommand : IKodiInputCommand
    {
        private string back      = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Back"" }";
        private string down      = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Down"" }";
        private string up        = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Up"" }";
        private string left      = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Left"" }";
        private string home      = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Home"" }";
        private string right     = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Right"" }";
        private string select    = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Input.Select"" }";
        private string playpause = @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Player.PlayPause"", ""params"": { ""playerid"": 1 }, ""id"": 1}";

        public string Back
        {
            get
            {
                return back;
            }

            set
            {
                back = value;
            }
        }

        public string Down
        {
            get
            {
                return down;
            }

            set
            {
                down = value;
            }
        }

        public string Up
        {
            get
            {
                return up;
            }

            set
            {
                up = value;
            }
        }

        public string Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public string Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public string Home
        {
            get
            {
                return home;
            }

            set
            {
                home = value;
            }
        }

        public string Select
        {
            get
            {
                return select;
            }

            set
            {
                select = value;
            }
        }

        public string PlayPause
        {
            get
            {
                return playpause;
            }

            set
            {
                playpause = value;
            }
        }

        public string SendText(string text)
        {
            return @"jsonrpc?request={""jsonrpc"": ""2.0"", ""method"": ""Application.SetVolume"",""params"": { ""text"": " + text + @",""done"": true } }";
        }
    }
}


