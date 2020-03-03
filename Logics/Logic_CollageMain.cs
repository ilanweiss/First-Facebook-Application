using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace FirstFBApp
{
    class Logic_CollageMain
    {
        public static readonly int[] sr_UserChosenAmount = { 4, 6, 9 };
        internal static List<Logic_PhotoWithLikes> getMostLikedPhotos(FacebookObjectCollection<Photo> user_photos, int num_of_collage_photos)
        {
            List<Logic_PhotoWithLikes> photoLikeList = new List<Logic_PhotoWithLikes>();

            foreach (Photo photo in user_photos)
            {
                long photo_likes = 0;
                dynamic photo_with_likes = FacebookWrapper.FacebookService.GetObject(photo.Id, "likes.summary(true)");
                photo_likes = photo_with_likes[0]["summary"]["total_count"];

                photoLikeList.Add(new Logic_PhotoWithLikes(photo, photo_likes));
            }

            photoLikeList.Sort();

            photoLikeList.Reverse();

            List<Logic_PhotoWithLikes> TopPhotoLikeList = new List<Logic_PhotoWithLikes>();

            int i = 0;
            foreach (Logic_PhotoWithLikes photo in photoLikeList)
            {
                if (i >= num_of_collage_photos)
                {
                    break;
                }
                TopPhotoLikeList.Add(photo);
                i++;
            }
            return TopPhotoLikeList;
        }

        internal static Bitmap getCollagePicture(User i_user, Album i_chosenAlbum, Boolean i_isAlbum, int i_enumChosenAmount)
        {

            FacebookObjectCollection<Photo> user_photos = i_isAlbum ? i_chosenAlbum.Photos : i_user.PhotosTaggedIn;

            // get top X pictures (Depanding on the user selection)
            // Arrange them in the image skeleton corresponding to the selection.
            List<Logic_PhotoWithLikes> photosWithLikes = getMostLikedPhotos(user_photos, sr_UserChosenAmount[i_enumChosenAmount]);

            // return the image and list open the CollageViewForm
            List<Image> actualImageFiles = new List<Image>();

            foreach (Logic_PhotoWithLikes photo in photosWithLikes)
            {
                Image image = photo.m_photo.ImageNormal;
                actualImageFiles.Add(image);
            }

            // Combine top # pictures into a collage

            return CollageBuilder.collageBuilder(actualImageFiles, i_enumChosenAmount, sr_UserChosenAmount[i_enumChosenAmount]);
        }
    }
}
