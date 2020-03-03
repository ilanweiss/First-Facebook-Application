using System.Drawing;
using System.Collections;

namespace FirstFBApp
{
    public class SubFramePosition : IEnumerable 
    {
        public Point Point { get; private set; }

        public Size Size { get; private set; }

        public SubFramePosition(Point i_Point, Size i_Size)
        {
            Point = i_Point;
            Size = i_Size;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
