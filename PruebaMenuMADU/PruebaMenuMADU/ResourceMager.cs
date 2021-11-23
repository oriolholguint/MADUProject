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
        public const String SOUNDS_PATH = "..\\..\\Resources\\sound\\";
        public const String IMAGES_PATH = "..\\..\\Resources\\images\\";

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

            if (File.Exists(IMAGES_PATH + imageName))
            {
                correcto = false;
            }
            else
            {

                try
                {
                    System.IO.File.Copy(imageFullPath, IMAGES_PATH + imageName);
                    correcto = true;
                }
                catch
                {
                    correcto = false;
                }
            }
            
            return correcto;
        }

        public static Boolean deleteImageFromResources(String relativeFullPath)
        {
            Boolean correcto = false;
            if (File.Exists(relativeFullPath))
            {

                try
                {
                    File.Delete(relativeFullPath);
                    correcto = true;
                }
                catch
                {
                    correcto = false;
                }
            }
            return correcto;

        }
        public static void deleteUnusedImages(List<Genero> esp, List<Genero> eng)//devuelve
        {
            List<string> imageNames = new List<string>();
            foreach (Genero gen in esp)
            {
                imageNames.Add(gen.ImagenFondo.Split('\\').Last());
                imageNames.Add(gen.ImagenMenu.Split('\\').Last());
                foreach (Personaje pj in gen.Personajes)
                {
                    imageNames.Add(pj.Imagen.Split('\\').Last());
                }
                foreach (Pregunta pg in gen.Preguntas)
                {
                    imageNames.Add(pg.Imagen.Split('\\').Last());
                }

            }
            foreach (Genero gen in eng)
            {
                imageNames.Add(gen.ImagenFondo.Split('\\').Last());
                imageNames.Add(gen.ImagenMenu.Split('\\').Last());
                foreach (Personaje pj in gen.Personajes)
                {
                    imageNames.Add(pj.Imagen.Split('\\').Last());
                }
                foreach (Pregunta pg in gen.Preguntas)
                {
                    imageNames.Add(pg.Imagen.Split('\\').Last());
                }

            }
            DirectoryInfo di = new DirectoryInfo(ResourceManager.IMAGES_PATH);

            FileInfo[] Images = di.GetFiles("*.*");
            foreach (FileInfo img in Images)
            {
                if (!imageNames.Contains(img.Name))
                {
                    File.Delete(ResourceManager.IMAGES_PATH + img.Name);
                }
            }
        }
        public static void deleteUnusedSounds(List<Genero> esp, List<Genero> eng)//devuelve
        {
            List<string> soundNames = new List<string>();
            foreach (Genero gen in esp)
            {
                soundNames.Add(gen.MusicaFondo.Split('\\').Last());

                foreach (Pregunta pg in gen.Preguntas)
                {
                    soundNames.Add(pg.Sonido.Split('\\').Last());
                }

            }
            foreach (Genero gen in eng)
            {
                soundNames.Add(gen.MusicaFondo.Split('\\').Last());

                foreach (Pregunta pg in gen.Preguntas)
                {
                    soundNames.Add(pg.Sonido.Split('\\').Last());
                }

            }
            
            DirectoryInfo di = new DirectoryInfo(ResourceManager.SOUNDS_PATH);

            FileInfo[] Sounds = di.GetFiles("*.*");
            foreach (FileInfo sound in Sounds)
            {
                if (!soundNames.Contains(sound.Name))
                {
                    File.Delete(ResourceManager.SOUNDS_PATH + sound.Name);
                }
            }
        }
    }
}
