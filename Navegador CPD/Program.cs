using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Navegador_CPD
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            AppContainer container = new AppContainer();
            container.Tabs.Add(new EasyTabs.TitleBarTab(container)
            {

                Content = new frmMain
                {
                    Text = "Nova guia"
                } 

            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);

        }
    }
}
