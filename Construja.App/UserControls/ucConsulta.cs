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
    public partial class ucConsulta : UserControl
    {
        private string ErrorMessage = string.Empty;
        private Domain.Placa placa;
        public ucConsulta()
        {
            InitializeComponent();
            List<string> placas = Domain.Placas.Get();
            lookUpEdit1.Properties.DataSource = placas;
            lookUpEdit1.Properties.NullText = "SELECIONE";
            ChangeVisibility(false);
        }

        private void ChangeVisibility(bool visibility)
        {
            lblData.Visible = visibility;
            lblCaixaSaida.Visible = visibility;
            lblCaixaVolta.Visible = visibility;
            lblObs.Visible = visibility;
            txtCxSaida.Visible = visibility;
            txtCxVolta.Visible = visibility;
            txtData.Visible = visibility;
            txtLog.Visible = visibility;
            txtObservacao.Visible = visibility;
            btnAtualizar.Visible = visibility;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var placaText = lookUpEdit1.Text;
            if (placaText == "SELECIONE")
            {
                MessageBox.Show("Favor Selecionar uma Placa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dal dal = new Dal();
            placa =
            dal.LoadOne(placaText, "SELECT TOP 1 [Id],[DataHora],[Placa],[QtdCaixaSaida],[QtdCaixaRetorno],[Observacao] FROM [Placa] WHERE [Placa] LIKE @placa ORDER BY [Id] DESC");
            if (placa == null)
            {
                MessageBox.Show("Não Existem dados para a placa selecionada", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
            int qtdCaixaRetorno = placa.qtdCaixaRetorno ?? 0;

            txtCxSaida.Text = placa.qtdCaixaSaida.ToString();
            txtCxVolta.Text = qtdCaixaRetorno.ToString();
            txtData.Text = placa.DataHora.ToShortDateString();
            txtObservacao.Text = placa.Observacao;

            ChangeVisibility(true);     
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var cxVolta = txtCxVolta.Text;
            var obs = txtObservacao.Text;
            var placaTexto = lookUpEdit1.Text;


            DateTime dta = DateTime.Now;
            string dtaStr = dta.ToString("dd/MM/yyyy HH:mm:ss");


            var msg = string.Format("{0} - Atualizando Placa {1} com {2} caixas de volta{3}", dtaStr, placaTexto, cxVolta,
                Environment.NewLine);
            txtLog.AppendText(msg);

            placa.qtdCaixaRetorno = int.Parse(cxVolta);
            placa.Observacao = obs;
            bool resultadoAtualizarPlaca = AtualizarPlaca();
            if (resultadoAtualizarPlaca)
            {
                DateTime resultDateTime = DateTime.Now;
                string strResultDateTime = dta.ToString("dd/MM/yyyy HH:mm:ss");
                var strResultMsg = string.Format("{0} - Placa Atualizada com Sucesso.{1}", strResultDateTime, Environment.NewLine);
                txtLog.AppendText(strResultMsg);
            }
            else
            {
                DateTime resultDateTime = DateTime.Now;
                string strResultDateTime = dta.ToString("dd/MM/yyyy HH:mm:ss");
                var strResultMsg = string.Format("{0} - Erro ao Atualizar placa. Detalhes {1}{2}", strResultDateTime, ErrorMessage, Environment.NewLine);
                txtLog.AppendText(strResultMsg);
            }

        }

        private bool AtualizarPlaca()
        {
            try
            {
                Dal dal = new Dal();
                dal.Update(placa,
                    "UPDATE [Placa] SET [QtdCaixaRetorno] = @QtdCaixaRetorno , [Observacao] = @Observacao WHERE [Id] = @Id");
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
