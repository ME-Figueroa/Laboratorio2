namespace NavegadorWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBar = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Actu = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.navegarToolStripMenuItem.Text = "Navegar";
            this.navegarToolStripMenuItem.Click += new System.EventHandler(this.navegarToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // addressBar
            // 
            this.addressBar.FormattingEnabled = true;
            this.addressBar.Items.AddRange(new object[] {
            "",
            ""});
            this.addressBar.Location = new System.Drawing.Point(0, 74);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(1001, 28);
            this.addressBar.TabIndex = 1;
            this.addressBar.SelectedIndexChanged += new System.EventHandler(this.addressBar_SelectedIndexChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1007, 74);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(122, 28);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Ir";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(1, 118);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1141, 333);
            this.webView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            this.webView.Click += new System.EventHandler(this.webView_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1007, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1007, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actu
            // 
            this.Actu.FormattingEnabled = true;
            this.Actu.Items.AddRange(new object[] {
            "Más recientes",
            "Más buscados"});
            this.Actu.Location = new System.Drawing.Point(875, 41);
            this.Actu.Name = "Actu";
            this.Actu.Size = new System.Drawing.Size(126, 28);
            this.Actu.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 451);
            this.Controls.Add(this.Actu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ComboBox addressBar;
        private System.Windows.Forms.Button goButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Actu;
    }
}

