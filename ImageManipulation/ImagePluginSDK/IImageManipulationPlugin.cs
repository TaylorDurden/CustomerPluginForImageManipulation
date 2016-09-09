using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginSDK
{
    public interface IImageManipulationPlugin
    {
        string Name { get; set; }
        void PerformEffects(IImageContext context);
    }
}
