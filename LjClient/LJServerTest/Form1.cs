using System;
using System.Windows.Forms;

namespace ClientLiveJornal
{
    public partial class mainForm : Form
	{
		LJClientFlat _flatServer;
		LJClientXml _xmlServer;

		ILog outputLog;
        ILog inputLog;

		public mainForm ()
		{
			InitializeComponent ();

			protocol.Items.Add ("Flat");
			protocol.Items.Add ("XML-RPC");
			protocol.SelectedIndex = 0;

            postComboBox.Items.Add("public");
            postComboBox.Items.Add("friend-only");
            postComboBox.Items.Add("private");
            postComboBox.SelectedIndex = 0;

            inputLog = new TextLog(mainTextBox);
            outputLog = new TextLog (logText);

			_flatServer = new LJClientFlat (outputLog);
			_xmlServer = new LJClientXml (outputLog);
		}

        private LJClient GetServer()
        {
            LJClient currentServer;
            if (protocol.SelectedIndex == 0)
                currentServer = _flatServer;
            else
                currentServer = _xmlServer;
            return currentServer;
        }

        private void LoginClear_Click (object sender, EventArgs e)
		{
			GetServer ().LoginClear (loginText.Text, passwordText.Text);
		}
        
		private void LoginChallenge_Click (object sender, EventArgs e)
		{
			GetServer ().LoginChallenge (loginText.Text, passwordText.Text);
		}

        private void Post_Click(object sender, EventArgs e)
        {
            GetServer().PostEventChallenge(mainTextBox.Text,
                    subjectText.Text,
                    tegsText.Text,
                    loginText.Text,
                    passwordText.Text);
        }

        private void LoginClearMD5_Click (object sender, EventArgs e)
		{
			GetServer ().LoginClearMD5 (loginText.Text, passwordText.Text);
		}

		private void Clear_Click (object sender, EventArgs e)
		{
			logText.Text = "";
		}

		private void OpenPageBtn_Click (object sender, EventArgs e)
		{
			string page = GetServer ().GetPrivatePage (urlText.Text,
				loginText.Text, passwordText.Text);

			PageViewer dlg = new PageViewer (page);
			dlg.ShowDialog ();
		}

        private void Clear_Click2(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }
    }
}