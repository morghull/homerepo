//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace ISLibrary
//{
//    public static class ImageListWrapper
//    {
//        static ImageListWrapper()
//        {
//            ImageList = new ImageList();
//            LoadImages(ImageList);
//        }
//        private static void LoadImages(ImageList imageList)
//        {
//            var images = Resources.ResourceManager
//                       .GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true)
//                       .Cast<System.Collections.DictionaryEntry>()
//                       .Where(x => x.Value.GetType() == typeof(System.Drawing.Image))
//                       .Select(x => new { Name = x.Key.ToString(), Image = (System.Drawing.Image)x.Value })
//                       .ToList();
//            foreach (var img in images)
//            {
//                imageList.Images.Add(img.Name.ToString(), img.Image);
//            }
//        }
//        public static ImageList ImageList { get; private set; }
//    }
//}
