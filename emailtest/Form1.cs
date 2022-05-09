using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using System.Linq;

namespace smstest
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
 

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                string mobileNo = number.Text;
                string smsText = sms.Text;
                string url = fullurl.Text;
                string userName = username.Text;
                string password = this.password.Text;
                string userId = this.userId.Text;

                bool isSuccess = SendSms(mobileNo,smsText,url,userName,password,userId);
                if (isSuccess)
                {
                    MessageBox.Show("SMS sent!");
                }
                else
                {
                    MessageBox.Show("SMS not sent!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public bool SendSms(string mobileNo, string smsText, string url, string userName, string password, string userId)
        {
            string htmlResult;
            string param = "user={0}&pass={1}&sms[0][0]={2}&sms[0][1]={3}&sms[0][2]={4}&sid={5}";
            param = string.Format(param, userName, password, mobileNo, smsText, 1, userId);
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    htmlResult = wc.UploadString(url, param);
                }
            }
            catch
            {
                return false;
            }
            var smsApiResponseRefferenceIdXml = XDocument.Parse(htmlResult);
            var sReferenceId = smsApiResponseRefferenceIdXml.Descendants("REFERENCEID").FirstOrDefault() == null
                ? string.Empty : smsApiResponseRefferenceIdXml.Descendants("REFERENCEID").First().Value;

            return sReferenceId != string.Empty;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
