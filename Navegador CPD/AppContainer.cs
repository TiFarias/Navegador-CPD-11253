using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using EasyTabs;

namespace Navegador_CPD
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Properties.Resources.logo_icon__1_;

        }
        public override TitleBarTab CreateTab()
        {
            try
            {
                // Criando uma instância do formulário principal (frmMain)
                var frm = new frmMain
                {
                    Text = "Carregando..." // Definindo texto inicial
                };

                // Você pode adicionar configurações de responsividade aqui, por exemplo:
                // - Usar Dock, Anchor, ou Layouts responsivos.
                frm.FormBorderStyle = FormBorderStyle.None; // Para que não tenha bordas fixas, caso deseje algo mais flexível

                // Aqui retornamos uma nova aba com o conteúdo configurado
                return new TitleBarTab(this)
                {
                    Content = frm
                };
            }
            catch (Exception ex)
            {
                // Log de erro ou tratamento caso algo dê errado
                MessageBox.Show($"Erro ao criar a nova aba: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
