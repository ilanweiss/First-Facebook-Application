using System.Collections.Generic;
using System.Drawing;

namespace FirstFBApp
{
    public class NinePicCollage : CollageBase
    {
        public override void createSubFramePositions()
        {
            m_CollageData.SubFramePositionList = new List<SubFramePosition>();
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(m_CollageData.InitPoint, new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(1 * m_CollageData.Size.Width / 3, 0), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size.Width / 3, 0), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(0 * m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(1 * m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(0 * m_CollageData.Size.Width / 3, 2 * m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(1 * m_CollageData.Size.Width / 3, 2 * m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size.Width / 3, 2 * m_CollageData.Size.Height / 3), new Size(m_CollageData.Size.Width / 3, m_CollageData.Size.Height / 3)));
        }
    }
}
