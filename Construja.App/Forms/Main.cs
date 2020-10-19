using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Construja.App.UserControls;
using DevExpress.XtraBars;

namespace Construja.App.Forms
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        { 
            ucCadastro cadastro = new ucCadastro();
            mainPanel.Controls.Add(cadastro);
            cadastro.Dock = DockStyle.Fill;
            cadastro.BringToFront();
            cadastro.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ucConsulta ucConsulta = new ucConsulta();
            mainPanel.Controls.Add(ucConsulta);
            ucConsulta.Dock = DockStyle.Fill;
            ucConsulta.BringToFront();
            ucConsulta.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ucHistorico ucHistorico = new ucHistorico();
            mainPanel.Controls.Add(ucHistorico);
            ucHistorico.Dock = DockStyle.Fill;
            ucHistorico.BringToFront();
            ucHistorico.Show();
        }
    }
}