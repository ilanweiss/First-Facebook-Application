using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FirstFBApp
{
    public abstract class CollageBase
    {
        protected CollageData m_CollageData = new CollageData();

        public abstract void createSubFramePositions();

        public Bitmap Collage
        {
            get
            {
                return m_CollageData.Collage;
            }
        }

        public void CreateCollage(ICollection<Image> i_SelectedImages)
        {
            m_CollageData.Collage = new Bitmap(m_CollageData.Size.Width, m_CollageData.Size.Height);
            using (Graphics g = Graphics.FromImage(m_CollageData.Collage))
            {
                int counter = 0;
                foreach (SubFramePosition subFramePosition in m_CollageData.SubFramePositionList)
                {
                    g.DrawImage(
                        ResizeImage.resizeImage(i_SelectedImages.ElementAt(counter),
                        subFramePosition.Size.Width,
                        subFramePosition.Size.Height),
                        subFramePosition.Point.X,
                        subFramePosition.Point.Y,
                        subFramePosition.Size.Width,
                        subFramePosition.Size.Height);
                    counter++;
                }

                g.DrawImage(m_CollageData.Collage, m_CollageData.InitPoint);
            }
        }
    }
}
