using System;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace ClientLiveJornal
{
    public abstract class LJClient
	{
		public abstract string GetChallenge ();
		public abstract string SessionGenerate (string login, string password);

		public abstract void LoginClear (string login, string password);
		public abstract void LoginClearMD5 (string login, string password);
		public abstract void LoginChallenge (string login, string password);
        public abstract void LoginCookies(string login, string password);

		public abstract void PostEventChallenge (string text, string subj, string tag,
			string user, string password);

		public ILog _log;

		public LJClient (ILog log)
		{
			_log = log;
		}

        public CookieCollection _cookies = new CookieCollection();

        // Адрес сервера 
        public abstract string ServerUrl
		{
			get;
		}

		public abstract string ContentType
		{
			get;
		}
        
		//обычная загрузка страницы
		public string GetPage (string url)
		{
            try
            {
                //задание порта и хоста для соединения
                int port = 80;
                Uri uri = new Uri(url);
                string host_name = uri.Host;
                string path = uri.PathAndQuery;
                
                //инициализация параметров для сокета
                IPHostEntry ipHost = Dns.GetHostEntry(host_name);
                IPAddress address = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(address, port);

                //создание сокета
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);
                if (socket.Connected)
                {
                    var header =
                        "GET " + path + " HTTP/1.1\r\n" +
                        "Host: " + host_name + "\r\n" +
                        "User-Agent: LJClientApplication" + "\r\n" +
                        "Connection: close" + "\r\n" + "\r\n";

                    //вывод в лог посылаемого запроса
                    _log.Write("\r\n$$$ Request:\r\n" + header);
                    byte[] bytesToSend = Encoding.UTF8.GetBytes(header);
                    var byteCount = socket.Send(bytesToSend, SocketFlags.None);

                    byte[] bytesReceived = new byte[10000000];
                    byteCount = socket.Receive(bytesReceived, SocketFlags.None);
                    _log.WriteLine("\n$$$ Response:\n" + Encoding.UTF8.GetString(bytesReceived));

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                    return Encoding.UTF8.GetString(bytesReceived);
                }
                else
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    _log.Write("Connection Failed!");
                    return "exit with error";
                }
            }
            catch (Exception ex)
            {
                _log.WriteLine("\r\n Exception: " + ex);
            }
            return "exit with error";
        }

		//подсчёт md5
		protected string ComputeMD5(string text)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider ();
			byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(text));

			StringBuilder sb = new StringBuilder();

			foreach( byte hashByte in hashBytes )
				sb.Append(Convert.ToString(hashByte, 16).PadLeft(2, '0'));

			return sb.ToString();
		}
        
		// Вычисление ответа на оклик
		protected string GetAuthResponse (string password, string challenge)
		{
			// md5 от пароля
			string hpass = ComputeMD5 (password);

			string constr = challenge + hpass;
			string auth_response = ComputeMD5 (constr);

			return auth_response;
		}

        //отправка запроса на сервер ЖЖ
		protected string SendRequest (string textRequest)
		{
            try
            {
                //преобразование запроса из строки в byte[]
                byte[] byteArray = Encoding.UTF8.GetBytes(textRequest);

                //задание порта и хоста для соединения
                int port = 80;
                string host_name = "www.livejournal.com";

                //инициализация параметров для сокета
                IPHostEntry ipHost = Dns.GetHostEntry(host_name);
                IPAddress address = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(address, port);

                //создание сокета
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);
                if (socket.Connected)
                {
                    var header =
                        "POST " + this.ServerUrl + " HTTP/1.1\r\n" +
                        "Host: " + host_name + "\r\n" +
                        "Content-type: " + this.ContentType + "\r\n" +
                        "Content-length: " + byteArray.Length + "\r\n" +
                        "\r\n" +
                        textRequest + "\r\n";

                    //вывод в лог посылаемого запроса
                    _log.Write("\r\n$$$ Request:\r\n" + header);
                    byte[] bytesToSend = Encoding.UTF8.GetBytes(header);
                    var byteCount = socket.Send(bytesToSend, SocketFlags.None);
                    
                    byte[] bytesReceived = new byte[1024];
                    byteCount = socket.Receive(bytesReceived, SocketFlags.None);
                    _log.WriteLine("\n$$$ Response:\n" + Encoding.UTF8.GetString(bytesReceived));

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                    return Encoding.UTF8.GetString(bytesReceived);
                } else
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    _log.Write("Connection Failed!");
                    return "exit with error";
                }                
            }
            catch (Exception ex)
            {
                _log.WriteLine("\r\n Exception: " + ex);
            }
            return "exit with error";
        }

    }
}
