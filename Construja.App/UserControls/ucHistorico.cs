using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Construja.App.Data;

namespace Construja.App.UserControls
{
    public partial class ucHistorico : UserControl
    {
        public ucHistorico()
        {
            InitializeComponent();
            Dal dal = new Dal();
            grid.DataSource = dal.LoadMany("SELECT [Id],[DataHora],[Placa],[QtdCaixaSaida],[QtdCaixaRetorno],[Observacao]FROM [Placa]");

        }
    }
}
