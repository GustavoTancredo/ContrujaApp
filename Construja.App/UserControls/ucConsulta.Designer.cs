namespace Construja.App.UserControls
{
    partial class ucConsulta
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new DevExpress.XtraEditors.TextEdit();
            this.lblCaixaSaida = new System.Windows.Forms.Label();
            this.txtCxSaida = new System.Windows.Forms.NumericUpDown();
            this.txtCxVolta = new System.Windows.Forms.NumericUpDown();
            this.lblCaixaVolta = new System.Windows.Forms.Label();
            this.txtObservacao = new DevExpress.XtraEditors.TextEdit();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxVolta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(73, 22);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit1.Size = new System.Drawing.Size(224, 22);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConsultar.Location = new System.Drawing.Point(0, 47);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(1141, 46);
            this.BtnConsultar.TabIndex = 9;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 129);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 25);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            this.lblData.Visible = false;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(165, 133);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(199, 22);
            this.txtData.TabIndex = 11;
            this.txtData.Visible = false;
            // 
            // lblCaixaSaida
            // 
            this.lblCaixaSaida.AutoSize = true;
            this.lblCaixaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaSaida.Location = new System.Drawing.Point(370, 131);
            this.lblCaixaSaida.Name = "lblCaixaSaida";
            this.lblCaixaSaida.Size = new System.Drawing.Size(140, 25);
            this.lblCaixaSaida.TabIndex = 12;
            this.lblCaixaSaida.Text = "Qtd Cxs Saida";
            this.lblCaixaSaida.Visible = false;
            // 
            // txtCxSaida
            // 
            this.txtCxSaida.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCxSaida.Enabled = false;
            this.txtCxSaida.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCxSaida.Location = new System.Drawing.Point(545, 132);
            this.txtCxSaida.Name = "txtCxSaida";
            this.txtCxSaida.Size = new System.Drawing.Size(171, 22);
            this.txtCxSaida.TabIndex = 16;
            this.txtCxSaida.Visible = false;
            // 
            // txtCxVolta
            // 
            this.txtCxVolta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCxVolta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCxVolta.Location = new System.Drawing.Point(909, 133);
            this.txtCxVolta.Name = "txtCxVolta";
            this.txtCxVolta.Size = new System.Drawing.Size(171, 22);
            this.txtCxVolta.TabIndex = 18;
            this.txtCxVolta.Visible = false;
            // 
            // lblCaixaVolta
            // 
            this.lblCaixaVolta.AutoSize = true;
            this.lblCaixaVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaVolta.Location = new System.Drawing.Point(744, 130);
            this.lblCaixaVolta.Name = "lblCaixaVolta";
            this.lblCaixaVolta.Size = new System.Drawing.Size(134, 25);
            this.lblCaixaVolta.TabIndex = 17;
            this.lblCaixaVolta.Text = "Qtd Cxs Volta";
            this.lblCaixaVolta.Visible = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(165, 180);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(915, 22);
            this.txtObservacao.TabIndex = 20;
            this.txtObservacao.Visible = false;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(6, 176);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(119, 25);
            this.lblObs.TabIndex = 19;
            this.lblObs.Text = "Observação";
            this.lblObs.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 222);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(1141, 46);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(3, 274);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1138, 375);
            this.txtLog.TabIndex = 22;
            this.txtLog.Visible = false;
            // 
            // ucConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtCxVolta);
            this.Controls.Add(this.lblCaixaVolta);
            this.Controls.Add(this.txtCxSaida);
            this.Controls.Add(this.lblCaixaSaida);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label1);
            this.Name = "ucConsulta";
            this.Size = new System.Drawing.Size(1146, 658);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxVolta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private DevExpress.XtraEditors.TextEdit txtData;
        private System.Windows.Forms.Label lblCaixaSaida;
        private System.Windows.Forms.NumericUpDown txtCxSaida;
        private System.Windows.Forms.NumericUpDown txtCxVolta;
        private System.Windows.Forms.Label lblCaixaVolta;
        private DevExpress.XtraEditors.TextEdit txtObservacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtLog;
    }
}
