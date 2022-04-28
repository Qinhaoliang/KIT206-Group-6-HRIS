using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HRIS
{
    class Modules  //Define a Modules class
    {
        const string strDefaultPic = "default.jpg";
        public static Image ReadDefaultImage() //The default image
        {
            Image image = null;
            try
            {
                image = Image.FromFile(strDefaultPic);
            }
            catch (Exception)
            {
                throw;
            }
            return image;
        }
        public static byte[] Image2Bytes(Image image) //Convert the image to a binary stream
        {
            if (image == null)
            {
                return null;
            }
            byte[] bytes;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            bytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(bytes, 0, bytes.Length);
            ms.Close();
            return bytes;
        }
        public static Image Bytes2Image(byte[] bytes) //Convert the binary stream to an image
        {
            Image image = null;
            MemoryStream ms = new MemoryStream(bytes);
            image = Image.FromStream(ms);
            return image;
        }
    }
}
