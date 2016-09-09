using System.Collections.Generic;
using System.Drawing;
using ImagePluginSDK;

namespace ImageManipulationApp
{
    public class ImageContext:IImageContext
    {
        public ImageContext(List<Image> images, int radius, int width, int height)
        {
            ImagesToManipulate = images;
            Radius = radius;
            Width = width;
            Height = height;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }
        public List<Image> ImagesToManipulate { get; set; }
        public List<Image> ImagesAfterManipulate { get; set; }
    }
}