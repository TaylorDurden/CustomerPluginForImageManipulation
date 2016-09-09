using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;

namespace ImagePluginSDK
{
    public interface IImageContext
    {
        int Height { get; set; }
        int Width { get; set; }
        int Radius { get; set; }
        List<Image> ImagesToManipulate { get; set; }
        List<Image> ImagesAfterManipulate { get; set; }
    }
}