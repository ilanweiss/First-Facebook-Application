using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace A20_Ex01_Ilan_302634654_Guy_310065362
{
   public class CollageCreator
    {
        private static ICollection<CollageBase> m_AllCollagesCollection;

        public static Bitmap CollageBuilder(List<Image> actualImageFiles,int i_indexChosenAmount, int i_UserChosenAmount)
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
}
