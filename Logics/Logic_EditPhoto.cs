using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;

namespace FirstFBApp
{
    class Logic_EditPhoto
    {

        internal static Image changeAndPresentFilters(Image i_originalImage, int i_brightness, int i_contrast, int i_blur)
        {
            // apply brightness
            Image imageToSend = modifyImage(i_originalImage, i_brightness, i_contrast, i_blur);
            // imageToSend = changeContrast(imageToSend, i_contrast);
            return imageToSend;
        }

        private static Image modifyImage(Image i_originalImage, int i_brightness, int i_contrast, int i_blur)
        {
            ImageFactory imageFactory = new ImageFactory();
            return imageFactory.Load(i_originalImage).GaussianBlur(i_blur).Brightness(i_brightness).Contrast(i_contrast).Image;
        }

        internal static Image blackWhiteFilter(Image i_originalImage)
        {
            ImageFactory imageFactory = new ImageFactory();

            return imageFactory.Load(i_originalImage).Filter(ImageProcessor.Imaging.Filters.Photo.MatrixFilters.GreyScale).Image;


        }

        internal static Image comicFilter(Image i_originalImage)
        {
            ImageFactory imageFactory = new ImageFactory();
            return imageFactory.Load(i_originalImage).Filter(ImageProcessor.Imaging.Filters.Photo.MatrixFilters.Comic).Image;
        }

        internal static Image gothamFilter(Image i_originalImage)
        {
            ImageFactory imageFactory = new ImageFactory();
            return imageFactory.Load(i_originalImage).Filter(ImageProcessor.Imaging.Filters.Photo.MatrixFilters.Gotham).Image;
        }

        internal static Image polaroidFilter(Image i_originalImage)
        {
            ImageFactory imageFactory = new ImageFactory();
            return imageFactory.Load(i_originalImage).Filter(ImageProcessor.Imaging.Filters.Photo.MatrixFilters.Polaroid).Image;
        }

        internal static Image sepiaFilter(Image i_originalImage)
        {
            ImageFactory imageFactory = new ImageFactory();
            return imageFactory.Load(i_originalImage).Filter(ImageProcessor.Imaging.Filters.Photo.MatrixFilters.Sepia).Image;
        }
    }
}
