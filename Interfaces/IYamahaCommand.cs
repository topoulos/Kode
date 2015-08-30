using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    
    public interface IYamahaCommand
    {
        string On { get; }
        string Off { get; }
        string HDMI1 { get; }
        string HDMI2 { get; }
        string HDMI3 { get; }
        string HDMI4 { get; }
        string VAUX { get;  }
        string VolUp { get; }
        string VolDown { get; }
        string VolMute { get; }

    }
}
