using System;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Web;
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

		public abstract void PostEventChallenge (string text, string subj, string tag,
			string user, string password);

		ILog _log;

        //т.к. прокси не используетс€
		WebProxy _proxy = null;

		public LJClient (ILog log)
		{
			_log = log;
		}

		protected CookieCollection _cookies = new CookieCollection();
        
		// јдрес сервера 
		public abstract string ServerUrl
		{
			get;
		}

		public abstract string ContentType
		{
			get;
		}
        
		//обычна€ загрузка страницы
		public string GetPage (string url)
		{
            //создание запроса
			HttpWebRequest request =
				(HttpWebRequest)WebRequest.Create (url);

			//заполнение параметров запроса
			//разрешение автоматических редиректов
			request.AllowAutoRedirect = true;

			request.Credentials = CredentialCache.DefaultCredentials;
			request.Method = "GET";
			
			// «аполн€ем параметры Proxy (_proxy == null, если прокси не используетс€)
			request.Proxy = _proxy;

			// ѕолучаем класс ответа
			HttpWebResponse response = (HttpWebResponse)request.GetResponse ();

			// „итаем ответ
			Stream responseStream = response.GetResponseStream ();
			StreamReader readStream = new StreamReader (responseStream, Encoding.UTF8);

			string currResponse = readStream.ReadToEnd ();

			readStream.Close ();
			response.Close ();

			return currResponse;
		}
        
		// ѕолучить строку, наход€щуюс€ между двум€ другими
		private string ExctractBetween (string text, string left, string right)
		{
			int leftpos = text.IndexOf (left);
			if (leftpos == -1)
			{
				return "";
			}

			int rightpos = text.IndexOf (right, leftpos + left.Length);
			if (rightpos == -1)
			{
				return "";
			}

			return text.Substring (leftpos + left.Length,
				rightpos - (leftpos + left.Length));
		}

		//подсчЄт md5
		protected string ComputeMD5(string text)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider ();
			byte[] hashBytes = md5.ComputeHash( Encoding.UTF8.GetBytes( text ) );

			StringBuilder sb = new StringBuilder();

			foreach( byte hashByte in hashBytes )
				sb.Append( Convert.ToString( hashByte, 16 ).PadLeft( 2, '0' ) );

			return sb.ToString();
		}
        
		// ¬ычисление ответа на оклик
		protected string GetAuthResponse (string password, string challenge)
		{
			// md5 от парол€
			string hpass = ComputeMD5 (password);

			string constr = challenge + hpass;
			string auth_response = ComputeMD5 (constr);

			return auth_response;
		}

        //отправка запроса на сервер ∆∆
		protected string SendRequest (string textRequest)
		{
            try
            {
                //преобразование запроса из строки в byte[]
                byte[] byteArray = Encoding.UTF8.GetBytes(textRequest);

                //задание порта и хоста дл€ соединени€
                int port = 80;
                string host_name = "www.livejournal.com";

                //инициализаци€ параметров дл€ сокета
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
                }
                
            }
            catch (Exception ex)
            {
                _log.WriteLine("\r\n Exception: " + ex);
            }
            return "exit";
        }

    }
}
