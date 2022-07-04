using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class FileProcess : IDisposable
    {
        private FileStream stream;
        public FileProcess()
        {
            stream = new FileStream("image.txt", FileMode.CreateNew);
        }


        public void Dispose()
        {
            stream.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();

        }

        public void WriteToFile(byte[] images)
        {
            stream.Write(images);
            stream.Close();   
        }
        
 
        public void ZippedFile(string path)
        {


            using FileStream compressedStream = File.Create(path);
            using GZipStream gZipStream = new GZipStream(compressedStream, CompressionMode.Compress);
               
            stream.CopyTo(gZipStream);
              

            
           
            //stream.CopyTo(gZipStream);
            //gZipStream.Close();
            //compressedStream.Close();



        }
    }
}
