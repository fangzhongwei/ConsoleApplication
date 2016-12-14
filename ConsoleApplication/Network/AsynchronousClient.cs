using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;
using ConsoleApplication.Helper;
using Google.Protobuf;


public class AsynchronousClient {
    // The port number for the remote device.
    //private const int port = 4200;

    // ManualResetEvent instances signal completion.
    private static ManualResetEvent connectDone = new ManualResetEvent(false);
    private static ManualResetEvent sendDone = new ManualResetEvent(false);
    private static ManualResetEvent receiveDone = new ManualResetEvent(false);

    private static int readStep = 1;
    private static int actionType = 0;
    private static int socketActionType = 0;
    private static int dataContentLength = 0;
    // The response from the remote device.
    private static  byte[] dataContentArray = new byte[0];

    public static void StartClient(String ip, int port) {
        // Connect to a remote device.
        try {
            // Establish the remote endpoint for the socket.
            // The name of the
            // remote device is "host.contoso.com".
            IPHostEntry ipHostInfo = Dns.Resolve(ip);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            // Create a TCP/IP socket.
            Socket client = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Connect to the remote endpoint.
            client.BeginConnect( remoteEP, new AsyncCallback(ConnectCallback), client);
            connectDone.WaitOne();

            // Send test data to the remote device.
            Send(client,"This is a test<EOF>");
            sendDone.WaitOne();

            // Receive the response from the remote device.
            Receive(client);
            receiveDone.WaitOne();

            // Write the response to the console.
            Console.WriteLine("Response received : {0}", System.Text.UTF8Encoding.UTF8.GetString(dataContentArray));

            // Release the socket.
            client.Shutdown(SocketShutdown.Both);
            client.Close();

        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    private static void ConnectCallback(IAsyncResult ar) {
        try {
            // Retrieve the socket from the state object.
            Socket client = (Socket) ar.AsyncState;

            // Complete the connection.
            client.EndConnect(ar);

            Console.WriteLine("Socket connected to {0}",
                client.RemoteEndPoint.ToString());

            // Signal that the connection has been made.
            connectDone.Set();
        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    private static void Receive(Socket client) {
        try {
            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = client;

            // Begin receiving the data from the remote device.
            client.BeginReceive( state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    private static void ReceiveCallback( IAsyncResult ar ) {
        try {
            // Retrieve the state object and the client socket
            // from the asynchronous state object.
            StateObject state = (StateObject) ar.AsyncState;
            Socket client = state.workSocket;

            // Read data from the remote device.
            int bytesRead = client.EndReceive(ar);

            Console.WriteLine("bytesRead IS : " + bytesRead);

            var result = string.Join(", ", state.buffer.Select(x => x.ToString()).ToArray());


            Console.WriteLine(result);

            if (bytesRead > 0) {
                // There might be more data, so store the data received so far.
                // state.sb.Append(Encoding.UTF8.GetString(state.buffer,0,bytesRead));
                state.arrayBuffer = ByteHelper.combineTowBytes(state.arrayBuffer, ByteHelper.readHeader(state.buffer, bytesRead));


                Console.WriteLine("case byteRead > 0, length:" + state.arrayBuffer.Length);

                if (bytesRead < 256)
                {
                    dataContentArray = ByteHelper.combineTowBytes(dataContentArray, state.arrayBuffer);
                    handle(readStep);
                }

                // Get the rest of the data.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            } else {


                Console.WriteLine("case byteRead == 0, length:" + state.arrayBuffer.Length);

                // All the data has arrived; put it in response.
                if (state.arrayBuffer.Length > 0) {
                    dataContentArray = ByteHelper.combineTowBytes(dataContentArray, state.arrayBuffer);
                    handle(readStep);
                }
                // Signal that all bytes have been received.
                receiveDone.Set();
            }
        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    private static void Send(Socket client, String data) {
        // Convert the string data to byte data using UTF8 encoding.
        //byte[] byteData = Encoding.UTF8.GetBytes(data);

        // Begin sending the data to the remote device.
        //client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);



        TestBuf testBuf = new TestBuf
        {
            ID  = 854123,
            Url = "www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工www.google.cc国工"
        };

        var generate = DataGenerator.generate(12,testBuf.ToByteArray());

        client.BeginSend(generate, 0, generate.Length, 0, new AsyncCallback(SendCallback), client);

    }

    private static void SendCallback(IAsyncResult ar) {
        try {
            // Retrieve the socket from the state object.
            Socket client = (Socket) ar.AsyncState;

            // Complete sending the data to the remote device.
            int bytesSent = client.EndSend(ar);
            Console.WriteLine("Sent {0} bytes to server.", bytesSent);

            // Signal that all bytes have been sent.
            sendDone.Set();
        } catch (Exception e) {
            Console.WriteLine(e.ToString());
        }
    }

    private static void handle(int step){
        switch (step)
        {
                case 1:
                int actionType = readIntFromBuffer();
                    if (actionType > 0)
                    {
                        socketActionType = actionType;
                        Console.WriteLine("socketActionType is : " + socketActionType);
                        readStep = 2;
                        if (dataContentArray.Length > 0)
                        {
                            handle(readStep);
                        }
                    }
                    break;
                case 2:
                int dataLength = readIntFromBuffer();
                if (dataLength > 0)
                {
                    dataContentLength = dataLength;
                    Console.WriteLine("dataContentLength is : " + dataContentLength);
                    readStep = 3;
                    if (dataContentArray.Length > 0)
                    {
                        handle(readStep);
                    }
                }
                break;
                case 3:
                ReadByteArrayResponse readByteArrayResponse = readBytes(dataContentLength);
                if (readByteArrayResponse.success)
                {
                    readStep = 1;
                    DataHandler.handle(socketActionType, readByteArrayResponse.data);
                    if (dataContentArray.Length > 0)
                    {
                        handle(readStep);
                    }
                }
                break;
                default:
                break;
        }
    }

    private static int readIntFromBuffer()
    {
        ReadByteArrayResponse readByteArrayResponse = readBytes(4);
        if (readByteArrayResponse.success)
        {
            return ByteHelper.ByteArrayToInt(readByteArrayResponse.data);
        }
        return -1;
    }

    private static ReadByteArrayResponse readBytes(int length)
    {
        ReadByteArrayResponse readByteArrayResponse = new ReadByteArrayResponse();
        int remainingLength = dataContentArray.Length - length;
        if (remainingLength >= 0)
        {
            readByteArrayResponse.success = true;
            readByteArrayResponse.data = ByteHelper.readHeader(dataContentArray, length);
            dataContentArray = ByteHelper.readTail(dataContentArray, remainingLength);
        }
        else
        {
            readByteArrayResponse.success = false;
        }
        return readByteArrayResponse;
    }
}