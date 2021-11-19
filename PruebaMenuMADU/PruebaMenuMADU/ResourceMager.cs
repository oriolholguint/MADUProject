using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public class ResourceManager
    {
        public const String SOUNDS_PATH = "..\\..\\resources\\sound\\";
        public const String IMAGES_PATH = "..\\..\\resources\\images\\";

        public static void addSoundToResources(String pathOrigin)
        {
            String imagePath = pathOrigin.Split('\\').Last();
            
            if(!File.Exists(SOUNDS_PATH + imagePath))
            {
                File.Move(pathOrigin, SOUNDS_PATH + imagePath);
            }
        }

        public static Boolean addImageToResources(String imageFullPath)
        {
            String imageName = imageFullPath.Split('\\').Last();
            Boolean correcto = false;

            if (File.Exists(IMAGES_PATH + imageName)) correcto = false;
            try
            {
                System.IO.File.Copy(imageFullPath, IMAGES_PATH + imageName);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static Boolean deleteImageFromResources(String relativeFullPath)
        {
            if (!File.Exists(relativeFullPath)) return false;
            try
            {
                File.Delete(relativeFullPath);
            }
            catch
            {
                return false;
            }
            return true;

        }
    }
}
