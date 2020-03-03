using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex02_Ilan_302634654_Guy_310065362
{
    class Logic_FriendMatchRating
    {
        public User m_friend   { get; set; }
        public int m_rating    { get; set; }

        public Logic_FriendMatchRating(User i_friend, int i_rating)
        {
            m_friend = i_friend;
            m_rating = i_rating;
        }

        public Logic_FriendMatchRating(User i_friend)
        {
            m_friend = i_friend;
            m_rating = 0;
        }

        public int CompareTo(Logic_FriendMatchRating obj)
        {
            if (this.m_rating > obj.m_rating)
            {
                return 1;
            }
            else if (this.m_rating < obj.m_rating)
            {
                return -1;
            }

            return 0;
        }

        internal void getRating(User m_user)
        {
            FacebookObjectCollection<Page> friends_likes = this.m_friend.LikedPages;
            FacebookObjectCollection<Page> user_likes = m_user.LikedPages;

            var CommonList = friends_likes.Intersect(user_likes);
            this.m_rating = CommonList.Count();
        }
    }
}
