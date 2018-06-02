namespace ClientLiveJornal
{
	partial class mainForm
	{
        // Требуемая переменная конструктора
        private System.ComponentModel.IContainer components = null;

        // Очистите все используемые ресурсы
        // disposing - true, если управляемые ресурсы должны быть удалены; в противном случае - false
        protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

        #region Windows Form Designer generated code

        // Необходимый метод для поддержки конструктора
        private void InitializeComponent ()
		{
            this.mainLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.protocolLbl = new System.Windows.Forms.Label();
            this.protocol = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loginChallenge = new System.Windows.Forms.Button();
            this.loginClearMD5 = new System.Windows.Forms.Button();
            this.loginClear = new System.Windows.Forms.Button();
            this.openPageBtn = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.tegs = new System.Windows.Forms.Label();
            this.tegsText = new System.Windows.Forms.TextBox();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.postButton = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            
            // mainLbl
            this.mainLbl.AutoSize = true;
            this.mainLbl.Location = new System.Drawing.Point(16, 12);
            this.mainLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLbl.Name = "mainLabel";
            this.mainLbl.Size = new System.Drawing.Size(98, 17);
            this.mainLbl.Text = "Авторизация:";
            
            // loginLbl
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(16, 52);
            this.loginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(51, 17);
            this.loginLbl.Text = "Логин:";

            // loginText
            this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginText.Location = new System.Drawing.Point(86, 50);
            this.loginText.Margin = new System.Windows.Forms.Padding(4);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(200, 22);
            this.loginText.TabIndex = 1;

            // passwordLbl
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(16, 92);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "label4";
            this.passwordLbl.Size = new System.Drawing.Size(61, 17);
            this.passwordLbl.Text = "Пароль:";

            // passwordText
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.Location = new System.Drawing.Point(86, 90);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(200, 22);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
           
            // label3
            this.protocolLbl.AutoSize = true;
            this.protocolLbl.Location = new System.Drawing.Point(16, 132);
            this.protocolLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.protocolLbl.Name = "label3";
            this.protocolLbl.Size = new System.Drawing.Size(76, 17);
            this.protocolLbl.Text = "Протокол:";
            
            // protocol
            this.protocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocol.FormattingEnabled = true;
            this.protocol.Location = new System.Drawing.Point(106, 130);
            this.protocol.Margin = new System.Windows.Forms.Padding(4);
            this.protocol.Name = "protocol";
            this.protocol.Size = new System.Drawing.Size(180, 24);
            this.protocol.TabIndex = 3;
            
            // groupBox1
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.loginChallenge);
            this.groupBox1.Controls.Add(this.loginClearMD5);
            this.groupBox1.Controls.Add(this.loginClear);
            this.groupBox1.Location = new System.Drawing.Point(10, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 112);
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия:";
            
            // loginChallenge
            this.loginChallenge.Location = new System.Drawing.Point(192, 23);
            this.loginChallenge.Margin = new System.Windows.Forms.Padding(4);
            this.loginChallenge.Name = "loginChallenge";
            this.loginChallenge.Size = new System.Drawing.Size(293, 28);
            this.loginChallenge.TabIndex = 5;
            this.loginChallenge.Text = "Авторизация (Challenge / Response)";
            this.loginChallenge.UseVisualStyleBackColor = true;
            this.loginChallenge.Click += new System.EventHandler(this.LoginChallenge_Click);
            
            // loginClearMD5
            this.loginClearMD5.Location = new System.Drawing.Point(8, 59);
            this.loginClearMD5.Margin = new System.Windows.Forms.Padding(4);
            this.loginClearMD5.Name = "loginClearMD5";
            this.loginClearMD5.Size = new System.Drawing.Size(219, 28);
            this.loginClearMD5.TabIndex = 6;
            this.loginClearMD5.Text = "Авторизация (Clear MD5)";
            this.loginClearMD5.UseVisualStyleBackColor = true;
            this.loginClearMD5.Click += new System.EventHandler(this.LoginClearMD5_Click);
            
            // loginClear
            this.loginClear.Location = new System.Drawing.Point(8, 23);
            this.loginClear.Margin = new System.Windows.Forms.Padding(4);
            this.loginClear.Name = "loginClear";
            this.loginClear.Size = new System.Drawing.Size(176, 28);
            this.loginClear.TabIndex = 4;
            this.loginClear.Text = "Авторизация (Clear)";
            this.loginClear.UseVisualStyleBackColor = true;
            this.loginClear.Click += new System.EventHandler(this.LoginClear_Click);
            
            // groupBox2
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.urlText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.openPageBtn);
            this.groupBox2.Location = new System.Drawing.Point(10, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(494, 100);
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотр блогов LiveJornal:";
            
            // openPageBtn
            this.openPageBtn.Location = new System.Drawing.Point(8, 64);
            this.openPageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openPageBtn.Name = "openPageBtn";
            this.openPageBtn.Size = new System.Drawing.Size(185, 28);
            this.openPageBtn.TabIndex = 9;
            this.openPageBtn.Text = "Загрузить страницу";
            this.openPageBtn.UseVisualStyleBackColor = true;
            this.openPageBtn.Click += new System.EventHandler(this.OpenPageBtn_Click);
            
            // urlText
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.Location = new System.Drawing.Point(80, 30);
            this.urlText.Margin = new System.Windows.Forms.Padding(4);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(404, 22);
            this.urlText.TabIndex = 8;
            
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.Text = "Адрес:";
            
            // clear
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(400, 760);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(106, 28);
            this.clear.TabIndex = 10;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);

            // logText
            this.logText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logText.Location = new System.Drawing.Point(16, 432);
            this.logText.Margin = new System.Windows.Forms.Padding(4);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logText.Size = new System.Drawing.Size(490, 300);

            // groupBox3
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.subjectText);
            this.groupBox3.Controls.Add(this.subject);
            this.groupBox3.Controls.Add(this.tegsText);
            this.groupBox3.Controls.Add(this.tegs);
            this.groupBox3.Location = new System.Drawing.Point(600, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(550, 110);
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Новый блог:";

            // subject label
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(8, 32);
            this.subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(50, 17);
            this.subject.Text = "Тема:";

            // subjectText
            this.subjectText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectText.Location = new System.Drawing.Point(70, 30);
            this.subjectText.Margin = new System.Windows.Forms.Padding(4);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(468, 22);
            this.subjectText.TabIndex = 11;

            // tags label
            this.tegs.AutoSize = true;
            this.tegs.Location = new System.Drawing.Point(8, 74);
            this.tegs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tegs.Name = "tags";
            this.tegs.Size = new System.Drawing.Size(50, 17);
            this.tegs.Text = "Теги:";

            // tagsText
            this.tegsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tegsText.Location = new System.Drawing.Point(70, 70);
            this.tegsText.Margin = new System.Windows.Forms.Padding(4);
            this.tegsText.Name = "tagsText";
            this.tegsText.Size = new System.Drawing.Size(468, 22);
            this.tegsText.TabIndex = 12;

            // mainTextBox
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Location = new System.Drawing.Point(600, 152);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(550, 582);
            this.mainTextBox.TabIndex = 13;

            // postComboBox
            this.postComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(600, 762);
            this.postComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(100, 24);
            this.postComboBox.TabIndex = 14;

            // postButton
            this.postButton.Location = new System.Drawing.Point(710, 760);
            this.postButton.Margin = new System.Windows.Forms.Padding(4);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(106, 28);
            this.postButton.TabIndex = 15;
            this.postButton.Text = "Запостить";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.Post_Click);

            // clearButton2
            this.clearButton2.Location = new System.Drawing.Point(1045, 760);
            this.clearButton2.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(106, 28);
            this.clearButton2.TabIndex = 15;
            this.clearButton2.Text = "Очистить";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.Clear_Click2);

            // mainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 806);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.protocol);
            this.Controls.Add(this.protocolLbl);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.postComboBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.clearButton2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "LiveJornal Client";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

		private System.Windows.Forms.Label loginLbl;
		private System.Windows.Forms.TextBox loginText;
		private System.Windows.Forms.Label passwordLbl;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Label protocolLbl;
		private System.Windows.Forms.ComboBox protocol;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button loginClear;
		private System.Windows.Forms.Button loginChallenge;
		private System.Windows.Forms.TextBox logText;
		private System.Windows.Forms.Button loginClearMD5;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button openPageBtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label tegs;
        private System.Windows.Forms.TextBox tegsText;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button clearButton2;
    }
}