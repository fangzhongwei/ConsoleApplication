using  System;
using  System.IO;
using ConsoleApplication.Helper;
using Google.Protobuf;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Proto.-----------------------------------------------------------------");

            string encode = DESHelper.Encode("123aaaa{}{}{}工123123123","ABCD1111");
            Console.WriteLine(encode);
            string decode = DESHelper.Decode(encode, "ABCD1111");
            Console.WriteLine(decode);

            TestBuf testBuf = new TestBuf
            {
              ID  = 12345,
              Url = "www.google.cc"
            };

            using (var output = File.Create("TestBuf.dat"))
            {
                CodedOutputStream codedOutputStream = new CodedOutputStream(output);
                testBuf.WriteTo(codedOutputStream);
                codedOutputStream.Flush();
                output.Flush();
                output.Close();
            }

            using (var input = File.OpenRead("TestBuf.dat"))
            {
                TestBuf john = TestBuf.Parser.ParseFrom(input);
                input.Close();
                Console.WriteLine("read id:" + john.ID);
                Console.WriteLine("read url:" + john.Url);

            }

            byte[] intToByteArray = ByteHelper.IntToByteArray(97854);
            Console.WriteLine(intToByteArray[0]);
            Console.WriteLine(intToByteArray[1]);
            Console.WriteLine(intToByteArray[2]);
            Console.WriteLine(intToByteArray[3]);

            int byteArrayToInt = ByteHelper.ByteArrayToInt(intToByteArray);
            Console.WriteLine(byteArrayToInt);

            //AsynchronousClient.StartClient();

            Console.WriteLine("Hello Proto.+OOOOOOOOOO++++++++++++++++++++++++++++++++++++++++++++++++");
            string str = Console.ReadLine();
            Console.WriteLine(str);

        }
    }
}