using System.Collections.Generic;
using System.Drawing;

namespace FirstFBApp
{
    public class FourPicCollage : CollageBase
    {
        public override void createSubFramePositions()
        {
            m_CollageData.SubFramePositionList = new List<SubFramePosition>();
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(m_CollageData.InitPoint, new Size(3 * m_CollageData.Size.Width / 7, m_CollageData.Size.Height / 2)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(3 * m_CollageData.Size.Width / 7, 0), new Size(4 * m_CollageData.Size.Width / 7, m_CollageData.Size.Height / 2)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(0 , m_CollageData.Size.Height / 2), new Size(4 * m_CollageData.Size.Width / 7, m_CollageData.Size.Height / 2)));
            m_CollageData.SubFramePositionList.Add(new SubFramePosition(new Point(4 * m_CollageData.Size.Width / 7, m_CollageData.Size.Height / 2), new Size(3 *  m_CollageData.Size.Width / 7 , m_CollageData.Size.Height / 2)));
        }
    }
}
