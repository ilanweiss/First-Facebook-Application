using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFBApp
{
    public static class CollageFactory
    {
        public static ICollection<CollageBase> CreateAllCollages()
        {
            List<CollageBase> allCollagesList = new List<CollageBase>();

            allCollagesList.Add(new FourPicCollage());
            allCollagesList.Add(new SixPicCollage());
            allCollagesList.Add(new NinePicCollage());

            return allCollagesList;
        }
    }
}
