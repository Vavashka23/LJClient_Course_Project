using System.Windows.Forms;

namespace ClientLiveJornal
{
    public class TextLog: ILog
	{
		TextBox _field;

		public TextLog (TextBox field)
		{
			_field = field;
		}

		#region ILog Members

		public void Write(string text)
		{
			_field.Text = _field.Text + text.Replace ("\n", "\r\n");
		}

		public void Clear()
		{
			_field.Text = "";
		}

		#endregion

		#region ILog Members


		public void WriteLine(string text)
		{
			_field.Text = _field.Text + text.Replace ("\n", "\r\n") + "\r\n";
		}

		#endregion
	}
}
