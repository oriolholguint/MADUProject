using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class UserFileManager
    {
        private static char USER_SEPARATOR = ':';
        private static String PATH = "..\\..\\etc\\passwd.txt";

        public static Boolean ComprobarUsuarioExiste(String usuario)
        {
            Boolean usuarioExiste = false;

            try
            {
                StreamReader sr = new StreamReader(PATH, true);

                String linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    String[] userInfo = linea.Split(USER_SEPARATOR);

                    if (userInfo[0].Equals(usuario))
                    {
                        usuarioExiste = true;
                    }
                }

                sr.Close();
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            catch (FileNotFoundException ex)
            {
               
            }

            return usuarioExiste;
        }

        public static Boolean ComprobarLogin(String usuario, String password)
        {
            Boolean loginCorrecto = false;

            try
            {
                StreamReader sr = new StreamReader(PATH);

                String linea;

                while ((linea = sr.ReadLine()) != null && !loginCorrecto)
                {
                    String[] info = linea.Split(':');
                    if (info[0].Equals(usuario) && ComprobarPassword(password, info[1]))
                    {
                        loginCorrecto = true;

                    }
                }

                sr.Close();
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            catch (FileNotFoundException ex)
            {

            }

            return loginCorrecto;
        }

        public static Boolean ComprobarUsuarioFrase(String usuario, String fraseRecuperacion)
        {
            Boolean usuarioExiste = false;

            try
            {
                StreamReader sr = new StreamReader(PATH);

                String linea;

                while ((linea = sr.ReadLine()) != null && !usuarioExiste)
                {
                    String[] info = linea.Split(':');
                    if (info[0].Equals(usuario) && ComprobarFraseRecuperacion(fraseRecuperacion, info[2]))
                    {
                        usuarioExiste = true;
                    }
                }

                sr.Close();
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            catch (FileNotFoundException ex)
            {

            }

            return usuarioExiste;
        }

        public static void AgregarUsuario(String userToAdd, String password, String fraseRecuperacion)
        {
            try
            {
                StreamWriter sw = new StreamWriter(PATH, true);

                String encryptPassword = Encriptar(password);
                String encryptPhrase = Encriptar(fraseRecuperacion);
                sw.Write(userToAdd + USER_SEPARATOR + encryptPassword + USER_SEPARATOR + encryptPhrase + "\n");

                sw.Close();
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            catch (FileNotFoundException ex)
            {

            }
        }

        public static void EliminarUsuario(String userToRemove)
        {
            List<String> InfoUsuarios = new List<String>();

            try
            {
                StreamReader sr = new StreamReader(PATH);

                String linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    String[] info = linea.Split(':');
                    if (!info[0].Equals(userToRemove))
                    {
                        InfoUsuarios.Add(linea);
                    }
                }

                sr.Close();

                StreamWriter sw = new StreamWriter(PATH);

                //Guardo usuarios anteriores
                foreach (String userLine in InfoUsuarios)
                {
                    sw.Write(userLine + "\n");
                }

                sw.Close();
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            catch (FileNotFoundException ex)
            {

            }
        }

        public static String Encriptar(String text)
        {
            String hashedPassword = BCrypt.Net.BCrypt.HashPassword(text);

            return hashedPassword;
        }

        private static Boolean ComprobarPassword(String text, String password)
        {
            return BCrypt.Net.BCrypt.Verify(text, password);
        }

        private static Boolean ComprobarFraseRecuperacion(String text, String fraseRecuperacion)
        {
            return BCrypt.Net.BCrypt.Verify(text, fraseRecuperacion);
        }
    }
}