using Construja.App.Data;
using Construja.App.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

namespace Construja.App.UserControls
{
    public partial class ucCadastro : UserControl
    {
        private string ErrorMessage = string.Empty;
        public ucCadastro()
        {
            InitializeComponent();
            List<string> placas = Domain.Placas.Get();
            lookUpEdit1.Properties.DataSource = placas;
            lookUpEdit1.Properties.NullText = "SELECIONE";
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var placa = lookUpEdit1.Text;
            if (placa == "SELECIONE")
            {
                MessageBox.Show("Favor Selecionar uma Placa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var caixa = nupQtdCaixas.Text;
            if (caixa == "0")
            {
                MessageBox.Show("A quantidade de caixas deve ser maior que zero", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DateTime dta = DateTime.Now;
            string dtaStr = dta.ToString("dd/MM/yyyy HH:mm:ss");


            var msg = string.Format("{0} - Cadastrando Placa {1} com {2} caixas{3}", dtaStr, placa, caixa,
                Environment.NewLine);
            textBox1.AppendText(msg);

            var resultadoSalvarPlaca= SalvarPlaca(dta, placa, caixa);
            if (resultadoSalvarPlaca)
            {
                DateTime resultDateTime = DateTime.Now;
                string strResultDateTime = dta.ToString("dd/MM/yyyy HH:mm:ss");
                var strResultMsg = string.Format("{0} - Placa Cadatrada com Sucesso.{1}", strResultDateTime,Environment.NewLine);
                textBox1.AppendText(strResultMsg);
            }
            else
            {
                DateTime resultDateTime = DateTime.Now;
                string strResultDateTime = dta.ToString("dd/MM/yyyy HH:mm:ss");
                var strResultMsg = string.Format("{0} - Erro ao Cadastrar placa. Detalhes {1}{2}", strResultDateTime, ErrorMessage, Environment.NewLine);
                textBox1.AppendText(strResultMsg);
            }

        }

        private bool SalvarPlaca(DateTime pDateTime, string pPlaca, string pCaixa)
        {
            try
            {
                Domain.Placa placa = new Domain.Placa(pDateTime,pPlaca, int.Parse(pCaixa));

                Dal dal = new Dal();
                dal.Insert(placa, "INSERT INTO[Placa]([DataHora],[Placa],[QtdCaixaSaida]) values(@DataHora,@placa,@qtdCaixaSaida)");

                //AppEntities _db = new AppEntities();
                //Placa row = new Placa();
                //row.DataHora = pDateTime;
                //row.Placa1 = pPlaca;
                //row.QtdCaixaSaida = int.Parse(pCaixa);
                //_db.Placa.Add(row);
                //_db.SaveChanges();
                return true;
            }

            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
            }
        }
    }
}
