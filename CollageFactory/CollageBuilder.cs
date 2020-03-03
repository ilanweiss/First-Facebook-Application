using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstFBApp
{
   public class CollageBuilder
    {
        private static ICollection<CollageBase> m_AllCollagesCollection;

        internal static Bitmap collageBuilder(List<Image> actualImageFiles,int i_indexChosenAmount, int i_UserChosenAmount)
        {
            if (actualImageFiles.Count() != i_UserChosenAmount)
            {
                throw new InvalidOperationException();
            }

            m_AllCollagesCollection = CollageFactory.CreateAllCollages();

            CollageBase m_collage = m_AllCollagesCollection.ElementAt(i_indexChosenAmount);

            m_collage.createSubFramePositions();
            m_collage.CreateCollage(actualImageFiles);

            return m_collage.Collage;
        }
    }
}

