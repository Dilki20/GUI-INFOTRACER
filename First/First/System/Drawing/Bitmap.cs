using System.Drawing.Imaging;
using System.IO;

namespace System.Drawing
{
    internal class Bitmap1
    {
        private string fileName;

        public Bitmap1(string fileName)
        {
            this.fileName = fileName;
        }

        internal void Save(MemoryStream memory, ImageFormat png)
        {
            throw new NotImplementedException();
        }

        internal void Save(string v, ImageFormat png)
        {
            throw new NotImplementedException();
        }
    }
}