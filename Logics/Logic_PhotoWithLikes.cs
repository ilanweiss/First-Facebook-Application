using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFBApp
{
    public class Logic_PhotoWithLikes : IComparable<Logic_PhotoWithLikes>
    {
        public Photo m_photo { get; set; }
        private long m_likes { get; set; }

        public Logic_PhotoWithLikes(Photo i_photo, long i_likes)
        {
            this.m_photo = i_photo;
            this.m_likes = i_likes;
        }

        public int CompareTo(Logic_PhotoWithLikes obj)
        {
            if (this.m_likes > obj.m_likes)
            {
                return 1;
            }
            else if (this.m_likes < obj.m_likes)
            {
                return -1;
            }

            return 0;
        }
    }
}
