using System;
using System.IO;
using ConsoleApplication.Helper;

public class DataHandler
{
    public static void handle(int actionType, byte[] data, string key)
    {
        byte[] decodeBytes = DESHelper.DecodeBytes(data, key);
        byte[] decompress = GZipHelper.Decompress(decodeBytes);

        using (MemoryStream stream = new MemoryStream(decompress))
        {
            TestBuf john = TestBuf.Parser.ParseFrom(stream);
            stream.Close();
            Console.WriteLine("read id:" + john.ID);
            Console.WriteLine("read url:" + john.Url);
        }
    }
}