namespace smstest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number = new System.Windows.Forms.TextBox();
            this.sms = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.fullurl = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(166, 68);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(189, 20);
            this.number.TabIndex = 0;
            this.number.Text = "01988353282";
            // 
            // sms
            // 
            this.sms.Location = new System.Drawing.Point(166, 94);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(189, 20);
            this.sms.TabIndex = 2;
            this.sms.Text = "test message";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(166, 146);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(189, 20);
            this.username.TabIndex = 6;
            this.username.Text = "ecom";
            // 
            // fullurl
            // 
            this.fullurl.Location = new System.Drawing.Point(166, 120);
            this.fullurl.Name = "fullurl";
            this.fullurl.Size = new System.Drawing.Size(189, 20);
            this.fullurl.TabIndex = 4;
            this.fullurl.Text = "http://sms.sslwireless.com/pushapi/dynamic/server.php";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(166, 172);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(189, 20);
            this.password.TabIndex = 8;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(166, 198);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(189, 20);
            this.userId.TabIndex = 13;
            this.userId.Text = "ECOM";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(133, 199);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "UID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(127, 173);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Pass";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(92, 147);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Username";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(129, 120);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "URL";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(125, 95);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "SMS";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(102, 69);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Number";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(296, 259);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(58, 25);
            this.metroTile1.TabIndex = 22;
            this.metroTile1.Text = "Send";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.metroTile1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 322);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.fullurl);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "SSL SMS Test";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox sms;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fullurl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

