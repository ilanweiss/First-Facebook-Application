using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex02_Ilan_302634654_Guy_310065362
{
    class Logic_FriendMatchView
    {
        internal static List<Logic_FriendMatchRating> findTopFriends(User i_user)
        {
            List<Logic_FriendMatchRating> friendsWithRatingList = new List<Logic_FriendMatchRating>();

            foreach (User i_friend in i_user.Friends)
            {
                Logic_FriendMatchRating m_friend = new Logic_FriendMatchRating(i_friend);
                m_friend.getRating(i_user);
                friendsWithRatingList.Add(m_friend);
            }

            friendsWithRatingList.Sort();
            friendsWithRatingList.Reverse();
            return friendsWithRatingList;
        }
    }
}
