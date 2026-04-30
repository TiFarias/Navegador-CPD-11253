namespace Navegador_CPD
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.goButton = new System.Windows.Forms.Button();
            this.btn_Fav = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.btn_RemovFav = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.buttonBloq = new System.Windows.Forms.Button();
            this.btn_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            resources.ApplyResources(this.webView, "webView");
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Name = "webView";
            this.webView.ZoomFactor = 1D;
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.Name = "goButton";
            this.Dicas.SetToolTip(this.goButton, resources.GetString("goButton.ToolTip"));
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // btn_Fav
            // 
            resources.ApplyResources(this.btn_Fav, "btn_Fav");
            this.btn_Fav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fav.FlatAppearance.BorderSize = 0;
            this.btn_Fav.Name = "btn_Fav";
            this.Dicas.SetToolTip(this.btn_Fav, resources.GetString("btn_Fav.ToolTip"));
            this.btn_Fav.UseVisualStyleBackColor = true;
            this.btn_Fav.Click += new System.EventHandler(this.btn_Fav_Click);
            // 
            // addressBar
            // 
            resources.ApplyResources(this.addressBar, "addressBar");
            this.addressBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addressBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.addressBar.BackColor = System.Drawing.Color.White;
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Name = "addressBar";
            this.Dicas.SetToolTip(this.addressBar, resources.GetString("addressBar.ToolTip"));
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // btn_RemovFav
            // 
            resources.ApplyResources(this.btn_RemovFav, "btn_RemovFav");
            this.btn_RemovFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemovFav.FlatAppearance.BorderSize = 0;
            this.btn_RemovFav.Name = "btn_RemovFav";
            this.Dicas.SetToolTip(this.btn_RemovFav, resources.GetString("btn_RemovFav.ToolTip"));
            this.btn_RemovFav.UseVisualStyleBackColor = true;
            this.btn_RemovFav.Click += new System.EventHandler(this.btn_RemovFav_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Home, "btn_Home");
            this.btn_Home.Name = "btn_Home";
            this.Dicas.SetToolTip(this.btn_Home, resources.GetString("btn_Home.ToolTip"));
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Forward.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Forward, "btn_Forward");
            this.btn_Forward.Name = "btn_Forward";
            this.Dicas.SetToolTip(this.btn_Forward, resources.GetString("btn_Forward.ToolTip"));
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.Dicas.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip"));
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Back, "btn_Back");
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Tag = "";
            this.Dicas.SetToolTip(this.btn_Back, resources.GetString("btn_Back.ToolTip"));
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // buttonBloq
            // 
            resources.ApplyResources(this.buttonBloq, "buttonBloq");
            this.buttonBloq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBloq.FlatAppearance.BorderSize = 0;
            this.buttonBloq.Name = "buttonBloq";
            this.buttonBloq.UseVisualStyleBackColor = true;
            this.buttonBloq.Click += new System.EventHandler(this.buttonBloq_Click);
            // 
            // btn_password
            // 
            resources.ApplyResources(this.btn_password, "btn_password");
            this.btn_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_password.FlatAppearance.BorderSize = 0;
            this.btn_password.Name = "btn_password";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.buttonBloq);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_RemovFav);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.btn_Fav);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.btn_Home);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMain";
            this.Dicas.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.ToolTip Dicas;
        private System.Windows.Forms.Button goButton;
        public System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button buttonBloq;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Back;
        public System.Windows.Forms.Button btn_Fav;
        public System.Windows.Forms.Button btn_RemovFav;
    }
}

