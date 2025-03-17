using System;
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
using Newtonsoft.Json;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        List<Url> urls = new List<Url>();
        public Form1()
        {
            InitializeComponent();
            //Url url = new Url();
            
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
            
            LeerHistorial(@"../../Historial.json");

            ActuHistorial();
        }

        String Link()
        {
            String link=string.Empty;
            if (!addressBar.Text.StartsWith("https://"))
            {
                link = "https://" + addressBar.Text;

            }
            if (!addressBar.Text.EndsWith(".com"))
            {
                link = "https://www.google.com/search?q=" + addressBar.Text;
            }
            if (addressBar.Text.StartsWith("https://"))
            {
                link = addressBar.Text;
            }

            return link;
        }

        public void guardar(String nombreArchivo)
        {
            string json = JsonConvert.SerializeObject(urls);
            //Se convierte de la lista al formato Json
            System.IO.File.WriteAllText(nombreArchivo, json);
        }

        void LeerHistorial(String filename)
        {
            StreamReader jsonStream = File.OpenText(filename);

            String json = jsonStream.ReadToEnd();
            jsonStream.Close();

            urls = JsonConvert.DeserializeObject<List<Url>>(json);
        }

        void ActuHistorial()
        {
            //addressBar.DataSource = null;
            addressBar.ValueMember = "link";
            addressBar.DataSource = urls;
            guardar(@"../../Historial.json");
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
            button1.Left = this.ClientSize.Width - goButton.Width;
            button2.Left = this.ClientSize.Width - goButton.Width;
            Actu.Width = button1.Left - Actu.Left;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(Link());
            }

            String archivo = @"../../Historial.json";
            Url link = new Url();

            if (urls == null) urls = new List<Url>();

            link = urls.Find(c => c.link == Link());                
            
            if (link == null)
            {
                Url url = new Url();
                url.link = Link();
                url.veces = 1;
                url.fechaBusqueda = DateTime.Now;
                urls.Add(url);
                guardar(archivo);
            }
            else
            {
                link.veces += 1;
                link.fechaBusqueda = DateTime.Now;

                guardar(archivo);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Actu.Text.Equals("Más recientes"))
            {
                urls = urls.OrderBy(a => a.fechaBusqueda).ToList();
            }
            else urls = urls.OrderByDescending(a => a.veces).ToList();

            ActuHistorial();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Url Basura = urls.Find(c => c.link == addressBar.SelectedItem.ToString());
            Url Basura = urls.Find(c => c.link == Link());

            urls.Remove(Basura);
            
            ActuHistorial();
            guardar(@"../../Historial.json");
        }

        private void webView_Click(object sender, EventArgs e)
        {

        }
    }
}
