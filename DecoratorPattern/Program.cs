using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace vallesmartin.HeadFirst.DecoratorPattern
{
    class Program
    {
        const int CLIENT_PORT = 8088;
        const int SERVER_PORT = 8087;

        static void Main(string[] args)
        {
            Stream fileStream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

            using (fileStream)
            {
                while (true)
                {
                    int data = fileStream.ReadByte();
                    if (data == -1)
                        break;
                    else
                        Console.Write(Convert.ToChar(data));
                }
            }

            Console.ReadKey();
        }








        private static void RunServer()
        {
            var tcpListener = new TcpListener(IPAddress.Any, SERVER_PORT);

            new Thread(() =>
            {
                tcpListener.Start();
                var client = tcpListener.AcceptTcpClient();

                var networkStream = client.GetStream();
                //var cryptoStream = new CryptoStream(networkStream, new SHA512Managed(), CryptoStreamMode.Read);
                //var gzipStream = new GZipStream(cryptoStream, CompressionMode.Decompress);
                //var bufferedStream = new BufferedStream(gzipStream, 64);

                var fileStream = new FileStream("result.txt", FileMode.Create);

                //using (bufferedStream)
                //{
                    using (fileStream)
                    {
                        while (true)
                        {
                            int data = networkStream.ReadByte();
                            if (data == -1) break;

                            fileStream.WriteByte((byte)data);
                        }
                    }
                //}

                //Process.Start("result.txt");
            }).Start();

            Thread.Sleep(1000);
        }

        private static void SendMessage(string message)
        {
            var client = new TcpClient("localhost", CLIENT_PORT);

            var networkStream = client.GetStream();
            var lowerStream = new LowerStream(networkStream);
            //var cryptoStream = new CryptoStream(networkStream, new SHA512Managed(), CryptoStreamMode.Write);
            //var gzipStream = new GZipStream(cryptoStream, CompressionMode.Compress);
            //var bufferedStream = new BufferedStream(gzipStream, 64);

            using (lowerStream)
            {
                foreach(var b in Encoding.Unicode.GetBytes(message))
                {
                    lowerStream.WriteByte(b);
                }
            }
        }

        private class LowerStream : Stream
        {
            private Stream _stream = Null;
            public override bool CanRead => throw new NotImplementedException();

            public override bool CanSeek => throw new NotImplementedException();

            public override bool CanWrite => throw new NotImplementedException();

            public override long Length => throw new NotImplementedException();

            public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public LowerStream(Stream stream)
            {
                _stream = stream;
            }
            public override void Flush()
            {
                throw new NotImplementedException();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override void WriteByte(byte b)
            {
            }
        }
    }
}
