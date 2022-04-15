using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HRIS
{
    class Modules  //定义一个Modules类
    {
        const string strDefaultPic = "default.jpg";
        public static Image ReadDefaultImage() //默认图片
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
        public static byte[] Image2Bytes(Image image) //将image转换为二进制流
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
        public static Image Bytes2Image(byte[] bytes) //将二进制流转换为image
        {
            Image image = null;
            MemoryStream ms = new MemoryStream(bytes);
            image = Image.FromStream(ms);
            return image;
        }
    }
}
