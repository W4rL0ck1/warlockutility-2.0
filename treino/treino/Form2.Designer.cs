namespace treino
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonDesligamento = new System.Windows.Forms.Button();
            this.buttonSalvarDns = new System.Windows.Forms.Button();
            this.buttonChecarDisco = new System.Windows.Forms.Button();
            this.buttonConverterUnidade = new System.Windows.Forms.Button();
            this.buttonChecarMTU = new System.Windows.Forms.Button();
            this.comboBoxNomeDns = new System.Windows.Forms.ComboBox();
            this.textBoxNomeServidor = new System.Windows.Forms.TextBox();
            this.labelRetorno = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxValor.Location = new System.Drawing.Point(12, 72);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(119, 20);
            this.textBoxValor.TabIndex = 2;
            // 
            // buttonDesligamento
            // 
            this.buttonDesligamento.Enabled = false;
            this.buttonDesligamento.Location = new System.Drawing.Point(35, 98);
            this.buttonDesligamento.Name = "buttonDesligamento";
            this.buttonDesligamento.Size = new System.Drawing.Size(75, 23);
            this.buttonDesligamento.TabIndex = 0;
            this.buttonDesligamento.Text = "Executar!";
            this.buttonDesligamento.UseVisualStyleBackColor = true;
            this.buttonDesligamento.Visible = false;
            this.buttonDesligamento.Click += new System.EventHandler(this.buttonDesligamento_Click);
            // 
            // buttonSalvarDns
            // 
            this.buttonSalvarDns.Enabled = false;
            this.buttonSalvarDns.Location = new System.Drawing.Point(35, 98);
            this.buttonSalvarDns.Name = "buttonSalvarDns";
            this.buttonSalvarDns.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarDns.TabIndex = 3;
            this.buttonSalvarDns.Text = "Salvar DNS";
            this.buttonSalvarDns.UseVisualStyleBackColor = true;
            this.buttonSalvarDns.Visible = false;
            this.buttonSalvarDns.Click += new System.EventHandler(this.buttonSalvarDns_Click);
            // 
            // buttonChecarDisco
            // 
            this.buttonChecarDisco.Enabled = false;
            this.buttonChecarDisco.Location = new System.Drawing.Point(35, 98);
            this.buttonChecarDisco.Name = "buttonChecarDisco";
            this.buttonChecarDisco.Size = new System.Drawing.Size(75, 23);
            this.buttonChecarDisco.TabIndex = 4;
            this.buttonChecarDisco.Text = "Executar!";
            this.buttonChecarDisco.UseVisualStyleBackColor = true;
            this.buttonChecarDisco.Visible = false;
            this.buttonChecarDisco.Click += new System.EventHandler(this.buttonChecarDisco_Click);
            // 
            // buttonConverterUnidade
            // 
            this.buttonConverterUnidade.Enabled = false;
            this.buttonConverterUnidade.Location = new System.Drawing.Point(35, 98);
            this.buttonConverterUnidade.Name = "buttonConverterUnidade";
            this.buttonConverterUnidade.Size = new System.Drawing.Size(75, 23);
            this.buttonConverterUnidade.TabIndex = 5;
            this.buttonConverterUnidade.Text = "Executar!";
            this.buttonConverterUnidade.UseVisualStyleBackColor = true;
            this.buttonConverterUnidade.Visible = false;
            this.buttonConverterUnidade.Click += new System.EventHandler(this.buttonConverterUnidade_Click);
            // 
            // buttonChecarMTU
            // 
            this.buttonChecarMTU.Enabled = false;
            this.buttonChecarMTU.Location = new System.Drawing.Point(35, 98);
            this.buttonChecarMTU.Name = "buttonChecarMTU";
            this.buttonChecarMTU.Size = new System.Drawing.Size(75, 23);
            this.buttonChecarMTU.TabIndex = 7;
            this.buttonChecarMTU.Text = "Executar!";
            this.buttonChecarMTU.UseVisualStyleBackColor = true;
            this.buttonChecarMTU.Visible = false;
            this.buttonChecarMTU.Click += new System.EventHandler(this.buttonChecarMTU_Click);
            // 
            // comboBoxNomeDns
            // 
            this.comboBoxNomeDns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomeDns.Enabled = false;
            this.comboBoxNomeDns.FormattingEnabled = true;
            this.comboBoxNomeDns.Items.AddRange(new object[] {
            "------------"});
            this.comboBoxNomeDns.Location = new System.Drawing.Point(15, 12);
            this.comboBoxNomeDns.Name = "comboBoxNomeDns";
            this.comboBoxNomeDns.Size = new System.Drawing.Size(118, 21);
            this.comboBoxNomeDns.TabIndex = 8;
            this.comboBoxNomeDns.Visible = false;
            this.comboBoxNomeDns.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomeDns_SelectedIndexChanged);
            // 
            // textBoxNomeServidor
            // 
            this.textBoxNomeServidor.Enabled = false;
            this.textBoxNomeServidor.Location = new System.Drawing.Point(13, 41);
            this.textBoxNomeServidor.Name = "textBoxNomeServidor";
            this.textBoxNomeServidor.Size = new System.Drawing.Size(118, 20);
            this.textBoxNomeServidor.TabIndex = 9;
            this.textBoxNomeServidor.Visible = false;
            // 
            // labelRetorno
            // 
            this.labelRetorno.AutoSize = true;
            this.labelRetorno.Location = new System.Drawing.Point(9, 13);
            this.labelRetorno.Name = "labelRetorno";
            this.labelRetorno.Size = new System.Drawing.Size(0, 13);
            this.labelRetorno.TabIndex = 10;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(35, 127);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar!";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 161);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelRetorno);
            this.Controls.Add(this.textBoxNomeServidor);
            this.Controls.Add(this.comboBoxNomeDns);
            this.Controls.Add(this.buttonChecarMTU);
            this.Controls.Add(this.buttonConverterUnidade);
            this.Controls.Add(this.buttonChecarDisco);
            this.Controls.Add(this.buttonSalvarDns);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.buttonDesligamento);
            this.MaximumSize = new System.Drawing.Size(170, 177);
            this.MinimumSize = new System.Drawing.Size(170, 177);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxValor;
        public System.Windows.Forms.Button buttonDesligamento;
        public System.Windows.Forms.Button buttonSalvarDns;
        public System.Windows.Forms.Button buttonChecarDisco;
        public System.Windows.Forms.Button buttonConverterUnidade;
        public System.Windows.Forms.Button buttonChecarMTU;
        public System.Windows.Forms.ComboBox comboBoxNomeDns;
        public System.Windows.Forms.TextBox textBoxNomeServidor;
        public System.Windows.Forms.Label labelRetorno;
        private System.Windows.Forms.Button buttonCancelar;
    }
}