using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CookieRunRedeemer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnRedeem_ClickAsync(object sender, EventArgs e)
        {
            foreach (string code in txtCodes.Lines)
            {
                if (String.IsNullOrWhiteSpace(code)) { continue; }
                DataToSend Data = new DataToSend();
                Data.email = txtUserID.Text;
                Data.coupon_code = code.Trim();
                var json = JsonConvert.SerializeObject(Data);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var url = "https://account.devplay.com/v2/coupon/ck";
                var client = new HttpClient();

                var response = await client.PostAsync(url, data);

                var result = await response.Content.ReadAsStringAsync();
                Result JSONResult = JsonConvert.DeserializeObject<Result>(result);
                rtbResponse.AppendText(code + ":" + Environment.NewLine);
                switch (JSONResult.code)
                {
                    case 20000:
                        LogSuccess("Success!");
                        break;

                    case 40006:
                        LogError("Invalid username?");
                        return;

                    case 42203:
                        Log("Code has already been redeemed on this account.");
                        break;

                    case 42201:
                        Log("Unknown code 42201, already redeemed?");
                        break;

                    case 42501:
                        Log("Code is expired.");
                        break;

                    default:
                        Log("Unknown result code: " + JSONResult.code);
                        break;
                }
            }
        }

        public void LogError(string ErrorMessage)
        {
            rtbResponse.SelectionColor = Color.Red;
            rtbResponse.AppendText("[ERROR] ");
            rtbResponse.SelectionColor = Color.Black;
            rtbResponse.AppendText(ErrorMessage + Environment.NewLine);
        }

        public void LogSuccess(string Message)
        {
            rtbResponse.SelectionColor = Color.Green;
            rtbResponse.AppendText(Message + Environment.NewLine);
            rtbResponse.SelectionColor = Color.Black;
        }

        public void Log(string Message)
        {
            rtbResponse.AppendText(Message + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Website = "https://cookierunkingdom.fandom.com/wiki/Coupon_Codes";
            Log("Attempting to autofill codes using the wiki at" + Environment.NewLine + Website + "...");
            WebClient HTMLDownloader = new WebClient();
            string HTML = HTMLDownloader.DownloadString(Website);
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(HTML);
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//table[1]/tbody/tr/td");
            int count = 0;
            foreach (var node in htmlNodes)
            {
                if (node.InnerText.Length < 16) { continue; }
                string MaybeCode = node.InnerText.Substring(0, 16);
                if (MaybeCode.Contains(",")) { continue; }
                if (MaybeCode.ToUpper() == MaybeCode)
                {
                    if (count == 0) txtCodes.Clear();
                    txtCodes.AppendText(MaybeCode + Environment.NewLine);
                    count++;
                }
            }
            LogSuccess("Done! Added " + count + " code(s)!");
        }

        private void rtbResponse_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Aida-Enna/CookieRunCodeRedeemer");
        }
    }

    internal class DataToSend
    {
        public string email = "";
        public string coupon_code = "";
    }

    public class Result
    {
        public int code;
    }
}