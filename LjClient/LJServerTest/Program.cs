using System;
using System.Windows.Forms;

namespace ClientLiveJornal
{
    static class Program
	{

        // Главная точка входа для приложения
        [STAThread]
		static void Main ()
		{
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new mainForm ());
		}
	}
}