using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using UrlShortener.Apis;
using System.Collections.Generic;

namespace UrlShortener
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Bitly Tab
        private void ProcessBtn2_Click(object sender, EventArgs e)
        {
            var bitlyShrink = new BitlyApi();
            if (String.IsNullOrEmpty(urlBox2.Text))
                outputBox2.Text = "No URL pasted.";
            else if (urlBox2.Text.Contains("http://") || (urlBox2.Text.Contains("https://")))
            {
                Thread.Sleep(100);
                outputBox2.Text = bitlyShrink.ShrinkBitlyUrl(urlBox2.Text);
                urlBox2.Text = "";
                UpdateListBox(outputBox2.Text);
            }
            else
                outputBox2.Text = "Wrong URL pasted.";
        }

        private void CopyBtn2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox2.Text);
        }
        #endregion

        #region TinyUrl Tab
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            var tinyShrink = new TinuUrlApi();
            if (String.IsNullOrEmpty(urlBox.Text))
                outputBox.Text = "No URL pasted.";
            else if (urlBox.Text.Contains("http://") || (urlBox.Text.Contains("https://")))
            {
                Thread.Sleep(100);
                outputBox.Text = tinyShrink.ShrinkTinyUrl(urlBox.Text);
                urlBox.Text = "";
                UpdateListBox(outputBox.Text);
            }
            else
                outputBox.Text = "Wrong URL pasted.";
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
        #endregion

        #region AboutTab
        private void LinkAuthorLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAuthorLbl.LinkVisited = false;
            Process.Start("https://github.com/8ucik");
        }

        private void LinkEmailLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkEmailLbl.LinkVisited = false;
            Process.Start("mailto:tom395tommy741@gmail.com?subject=Hello_&_I_would_like_to_report_a_bug.");

        }

        private void TyBtn_Click(object sender, EventArgs e)
        {
            tyLbl.Text = "Thank you for downloading this small program of mine." +
                "\nI have made it for educational purposes and am really " +
                "\nhappy that someone makes use of it." +
                "\nThank you.";
        }
        #endregion

        #region Generic functions
        private void UpdateListBox(string boxElement)
        {
            urlListBox.BeginUpdate();
            urlListBox.Items.Add(boxElement);
            urlListBox.EndUpdate();
        }
        
        private void UrlListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C && urlListBox.SelectedItems.Count > 0)
            {
                var selection = urlListBox.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, selection);
            }
        }

        private void ClearClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        //Need to fix this. I don't know where it is being saved
        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (TextWriter tw = new StreamWriter("urls-" + DateTime.Now.ToString("yyMMdd_HHmmss")))
                {
                    foreach (var elem in urlListBox.Text)
                        tw.WriteLine(elem);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                new Exception("Error. The list is empty.", ex);
            }
        }

        #endregion

        private void ClearListBtn_Click(object sender, EventArgs e)
        {
            foreach (var elem in urlListBox.Text)
                urlListBox.Text.Remove(elem);
        }
    }
}