using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace ClientLiveJornal
{
    public class LJClientFlat: LJClient
	{
        public LJClientFlat(ILog log)
            : base(log)
        { }

		public override void LoginClear (string user, string password)
		{
			string request = string.Format ("mode=login&auth_method=clear&user={0}&password={1}",
				user,
                password);

			this.SendRequest (request, null);
		}
        
		// Сделать словарь из полученных в ходе запроса значений
		private StringDictionary MakeDict (string response)
		{
			string[] split = response.Split ("\n".ToCharArray ());

			StringDictionary dict = new StringDictionary();
			for (int i = 0; i < split.Length - 1; i += 2)
			{
				dict[split[i]] = split[i + 1];
			}
			return dict;
		}

		public override string ServerUrl
		{
			get { return "/interface/flat"; }
		}

		public override string ContentType
		{
			get { return "application/x-www-form-urlencoded"; }
		}

		public override void LoginChallenge (string username, string password)
		{
			string challenge = GetChallenge ();

			string auth_response = GetAuthResponse (password, challenge);

			string request = string.Format ("mode=login&auth_method=challenge&auth_challenge={0}&auth_response={1}&user={2}", challenge, auth_response, username);

			SendRequest (request, null);
		}

		public override string GetChallenge ()
		{
			string request = "mode=getchallenge";
			string challengeResponse = SendRequest (request, null);

			StringDictionary dict = MakeDict (challengeResponse);
			if (dict["success"] == "OK")
			{
				return dict["challenge"];
			}

			return "";
		}

		public override void PostEventChallenge (string text, string subj, string tag, 
			string user, string password, string security)
		{
			string challenge = GetChallenge ();

			string auth_response = GetAuthResponse (password, challenge);

            string newText = HttpUtility.UrlEncode(text) + '\n' + HttpUtility.UrlEncode(tag);

            DateTime date = DateTime.Now;

			string request = string.Format ("mode=postevent&auth_method=challenge&auth_challenge={0}&auth_response={1}&user={2}&event={3}&subject={4}&security={5}&allowmask=0&year={6}&mon={7}&day={8}&hour={9}&min={10}&ver=1",
				challenge, 
				auth_response, 
				user, 
				newText,
                HttpUtility.UrlEncode(subj),
                security,
				date.Year, date.Month, date.Day, 
				date.Hour, date.Minute);

			SendRequest (request, null);
		}

		public override string SessionGenerate (string login, string password)
		{
			string challenge = GetChallenge ();

			string auth_response = GetAuthResponse (password, challenge);

			string request = string.Format ("mode=sessiongenerate&auth_method=challenge&auth_challenge={0}&auth_response={1}&user={2}&expiration=long", challenge, auth_response, login);

			string challengeResponse = SendRequest (request, null);

           /* StringDictionary dict = MakeDict (challengeResponse);
			if (dict["success"] != "OK")
			{
				return "";
			}

			return dict["ljsession"];*/
            return challengeResponse;
		}

        public override void LoginCookies(string login, string password)
        {
            string ljsession = SessionGenerate(login, password);

            /*Cookie cookie = new Cookie("ljsession", ljsession, "/", "livejournal.com");

            _cookies = new CookieCollection();
            _cookies.Add(cookie);*/

            string cookie = "ljsession=" + ljsession+ "/" + "livejournal.com";

            string request = string.Format("mode=login&auth_method=cookie&user={0}", login);

            SendRequest(request, cookie);
        }

        public override void LoginClearMD5 (string user, string password)
		{
			string request = string.Format ("mode=login&auth_method=clear&user={0}&hpassword={1}",
				user, ComputeMD5 (password) );

			this.SendRequest (request, null);
		}
	}
}
