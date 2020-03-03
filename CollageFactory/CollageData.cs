using System.Collections.Generic;
using System.Drawing;

namespace FirstFBApp
{
    public class CollageData
    {
        public enum eCollageType
        {
            FOUR_IMAGES, SIX_IMAGES, NINE_IMAGES
        }

        private const int k_Hight = 900;
        private const int k_Width = 900;
        private readonly Point r_InitPoint = new Point(0, 0);

        public Bitmap Collage { get; set; }

        public List<SubFramePosition> SubFramePositionList { get; set; }

        public Size Size
        {
            get
            {
                return new Size(k_Width,k_Hight);
            }
        }

        public Point InitPoint
        {
            get
            {
                return r_InitPoint;
            }
        }
    }
}
