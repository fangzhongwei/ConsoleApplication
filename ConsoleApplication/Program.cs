using  System;
using  System.IO;
using System.Linq;
using System.Text;
using ConsoleApplication.Helper;
using Google.Protobuf;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main1(string[] args)
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

        public static void Main11(string[] args)
        {
            byte[] array = Encoding.GetEncoding("UTF-8").GetBytes("aaaaaabbbbbbbbcccccccddddddffff中国11111");
            var result = string.Join(",", array.Select(x => x.ToString()).ToArray());


            Console.WriteLine(result);



            byte[] compress = GZipHelper.compress(array);
            var result2 = string.Join(",", compress.Select(x => x.ToString()).ToArray());

            Console.WriteLine("length:" + compress.Length);
            Console.WriteLine(result2);
            AsynchronousClient.StartClient("127.0.0.1", 4200);

            Console.WriteLine("Hello Proto.+OOOOOOOOOO++++++++++++++++++++++++++++++++++++++++++++++++");
        }

        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            SMSNotify sms = new SMSNotify();
            Account account = new Account(1000);
            CreditCard.SpendMoney += account.Update;
            CreditCard.SpendMoney += sms.Update;
            creditCard.SpendAmount = 200;
        }
    }
}