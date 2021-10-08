using System;
using System.IO;
using System.IO.Compression;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFile = @"C:\temp\newfile.txt";
            string outFile = @"C:\temp\newfile.txt.gz";
            string outFileDecomp = @"C:\temp\newfile_decomp.txt";
            CompressFile(inFile, outFile);
            Console.WriteLine("Successfully compressed");

            DecompressFile(outFile, outFileDecomp);
            Console.WriteLine("Successfully decompressed");

            Console.ReadKey();
        }

        static void CompressFile(string inFileName, string outFileName)
        {
            FileStream sourceFile = File.OpenRead(inFileName);
            FileStream destFile = File.Create(outFileName);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);

            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }

            compStream.Close();
        }

        static void DecompressFile(string inFileName, string outFileName)
        {
            FileStream sourceFile = File.OpenRead(inFileName);
            FileStream destFile = File.Create(outFileName);

            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);

            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();
        }
    }
}
