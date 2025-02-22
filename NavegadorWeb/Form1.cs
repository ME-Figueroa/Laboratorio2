﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;
using System.IO;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;

            string fileName = @"Historial.txt";
            FileStream stream;
            if (!File.Exists(fileName))
            {
                stream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            }else{
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            }
            StreamReader reader = new StreamReader(stream);
            int a = 0;

            while (reader.Peek() > -1 && a < 10)
            {
                addressBar.Items.Add(reader.ReadLine());
                a++;
            }
            reader.Close();
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                args.Cancel = true;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (!addressBar.Text.StartsWith("https://")){
                    webView.CoreWebView2.Navigate("https://"+addressBar.Text);

                }
                if (!addressBar.Text.EndsWith(".com"))
                {                   
                    webView.CoreWebView2.Navigate("https://www.google.com/search?q=" + addressBar.Text);
                }
                if(addressBar.Text.StartsWith("https://"))
                {
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }           
            }

            String archivo = @"Historial.txt";
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(addressBar.Text);

            writer.Close();            
        }

        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.google.com");
        }

        private void addressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
