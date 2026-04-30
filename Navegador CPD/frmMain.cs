using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Microsoft.Web.WebView2.Core;
using Win32Interop.Enums;

/*CREATED BY JONNATAN FARIAS*/
/*Altered by WELLER DE SOUZA*/

namespace Navegador_CPD
{

    public partial class frmMain : Form

    {

        //string caminho = @"\\192.168.";

        String nomeMaquina = Environment.MachineName;
        public frmMain()

        {
            
                
            InitializeComponent();
            InitializeAsync();
        }



        ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
           

            //InitBrowser();
            // verifica se existe o arquivo
            if (!File.Exists(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt"))
            {
                File.Create(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt").Close();
            }
            else
            {
                this.comboBox1.Items.Clear();

                // lê os items do arquivo...
                string[] lines = File.ReadAllLines(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt");

                foreach (String cadaItem in lines ) {
                    if (!comboBox1.Items.Contains(cadaItem)) {
                        this.comboBox1.Items.Add(cadaItem);
                    }
                }
                //this.comboBox1.Items.AddRange(lines);
            }
        }

        //alterando
        /*
        private async Task Initizated()
        {
            await webView.EnsureCoreWebView2Async(null);  
        }

        public async void InitBrowser()

        {

            await Initizated();
            webView.CoreWebView2.Navigate("https://www.atacadaofarias.com.br");
            webView.CoreWebView2.DownloadStarting += delegate (object sender, CoreWebView2DownloadStartingEventArgs args)
            {

                args.Handled = false;
              
            };


        }*/

        //alterando
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.NavigationCompleted += WebView_NavigationCompleted;
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");

            webView.CoreWebView2.Navigate("https://www.atacadaofarias.com.br");
            webView.CoreWebView2.DownloadStarting += delegate (object sender, CoreWebView2DownloadStartingEventArgs args)
            {

                args.Handled = false;
              
            };
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();

            addressBar.Text = uri;

            webView.CoreWebView2.PostWebMessageAsString(uri);

          //  UpdateTitleBar(uri);

        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // Depois de concluir a navegação, pegar o título atualizado da página
                string pageTitle = webView.CoreWebView2.DocumentTitle;

                // Atualizar a barra de endereços e a aba
                addressBar.Text = webView.Source.ToString();  
                UpdateTitleBar(pageTitle);  
            }
            else
            {
                // Caso a navegação tenha falhado, você pode tratar o erro aqui
                addressBar.Text = "Erro ao carregar a página";
            }
        }

        private void UpdateTitleBar(string pageTitle)
        {
            // Acessa a aba ativa no container da aplicação
            var parentForm = this.ParentForm as AppContainer;

            if (parentForm != null)
            {
                // Encontrar a aba ativa e atualizar seu título com a URL atual
                foreach (var tab in parentForm.Tabs)
                {
                    if (tab.Content == this)  // Verifica se a aba contém o frmMain atual
                    {
                      //  String titlePage = webView.CoreWebView2.DocumentTitle;
                        tab.Caption = pageTitle;  // Atualiza o título da aba com a URL
                        break;
                    }
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            if (Uri.IsWellFormedUriString(addressBar.Text, UriKind.Absolute)) //Verifica se o texto digitado é uma url válida...
            {
                Uri uri = new Uri(addressBar.Text);
                webView.CoreWebView2.Navigate(uri.ToString()); //Caso seja uma Url válida navegará para ela
            }
            else
            {
                Uri uri = new Uri(@"https://www.google.com.br/search?q=" + addressBar.Text.Replace(" ", "+"));
                webView.CoreWebView2.Navigate(uri.ToString()); //Caso contrário, irá realizar a pesquisa no google
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.atacadaofarias.com.br");
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Uri.IsWellFormedUriString(addressBar.Text, UriKind.Absolute)) //Verifica se o texto digitado é uma url válida...
                {
                    Uri uri = new Uri(addressBar.Text);
                    webView.CoreWebView2.Navigate(uri.ToString()); //Caso seja uma Url válida navegará para ela
                }
                else
                {
                    Uri uri = new Uri(@"https://www.google.com.br/search?q=" + addressBar.Text.Replace(" ", "+"));
                    webView.CoreWebView2.Navigate(uri.ToString()); //Caso contrário, irá realizar a pesquisa no google
                }
            }

        }

        private void btn_Fav_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(addressBar.Text);
            MessageBox.Show("FAVORITO SALVO COM SUCESSO!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // salva os items...
            string[] items = new string[this.comboBox1.Items.Count];
            this.comboBox1.Items.CopyTo(items, 0);
            File.WriteAllLines(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt", items);

        }

        private void btn_RemovFav_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {

                MessageBox.Show("POR FAVOR SELECIONAR UM FAVORITO PARA EXCLUIR!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                string[] Lines = File.ReadAllLines(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt");
                File.Delete(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt");// Deleting the file
                using (StreamWriter sw = File.AppendText(@"\\srv01-ad\Public\Favoritos navegador cpd\Navegadorcpdfavoritos" + nomeMaquina + ".txt"))

                {
                    foreach (string line in Lines)
                    {
                        if (line.IndexOf(addressBar.Text) >= 0)
                        {
                            //Skip the line
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("FAVORITO REMOVIDO COM SUCESSO!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {

                var fav = addressBar.Text = comboBox1.SelectedItem.ToString();
                webView.CoreWebView2.Navigate(fav);

            }
        }



        private void btn_password_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword(this);
            frm.Show();

        }

        private void buttonBloq_Click(object sender, EventArgs e)
        {

            if (btn_Fav.Enabled == false && btn_RemovFav.Enabled == false && addressBar.Enabled == false)
            {

                MessageBox.Show("Não há bloqueios a serem realizados.", "Mensagem interna", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Bloqueio  Confirmado", "Mensagem interna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addressBar.Enabled = false;
                btn_Fav.Enabled = false;
                btn_RemovFav.Enabled = false;
            }      
        }
    }

}
