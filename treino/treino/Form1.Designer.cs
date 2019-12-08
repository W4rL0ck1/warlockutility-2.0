namespace treino
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxLista1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLista2 = new System.Windows.Forms.ComboBox();
            this.labelSelecionarTeste1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExecutarTeste = new System.Windows.Forms.Button();
            this.labelTeste = new System.Windows.Forms.Label();
            this.labelSelecionarTeste2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTipSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCarregarDefault = new System.Windows.Forms.Button();
            this.buttonSalvarDados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLista1
            // 
            this.comboBoxLista1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLista1.FormattingEnabled = true;
            this.comboBoxLista1.Items.AddRange(new object[] {
            "Testes de Latencia",
            "Manutenção de IP",
            "Desligamento do Windows por Tempo",
            "Outros"});
            this.comboBoxLista1.Location = new System.Drawing.Point(3, 38);
            this.comboBoxLista1.Name = "comboBoxLista1";
            this.comboBoxLista1.Size = new System.Drawing.Size(247, 21);
            this.comboBoxLista1.TabIndex = 0;
            this.comboBoxLista1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLista1_SelectedIndexChanged);
            // 
            // comboBoxLista2
            // 
            this.comboBoxLista2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLista2.FormattingEnabled = true;
            this.comboBoxLista2.Items.AddRange(new object[] {
            "---------------"});
            this.comboBoxLista2.Location = new System.Drawing.Point(6, 36);
            this.comboBoxLista2.Name = "comboBoxLista2";
            this.comboBoxLista2.Size = new System.Drawing.Size(146, 21);
            this.comboBoxLista2.TabIndex = 1;
            this.comboBoxLista2.SelectedIndexChanged += new System.EventHandler(this.comboBoxLista2_SelectedIndexChanged);
            // 
            // labelSelecionarTeste1
            // 
            this.labelSelecionarTeste1.AutoSize = true;
            this.labelSelecionarTeste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionarTeste1.Location = new System.Drawing.Point(6, 22);
            this.labelSelecionarTeste1.Name = "labelSelecionarTeste1";
            this.labelSelecionarTeste1.Size = new System.Drawing.Size(212, 13);
            this.labelSelecionarTeste1.TabIndex = 2;
            this.labelSelecionarTeste1.Text = "Selecione um Tipo de Teste Abaixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // buttonExecutarTeste
            // 
            this.buttonExecutarTeste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExecutarTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExecutarTeste.Location = new System.Drawing.Point(36, 30);
            this.buttonExecutarTeste.Name = "buttonExecutarTeste";
            this.buttonExecutarTeste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExecutarTeste.Size = new System.Drawing.Size(97, 27);
            this.buttonExecutarTeste.TabIndex = 4;
            this.buttonExecutarTeste.Text = "Executar!";
            this.buttonExecutarTeste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExecutarTeste.UseVisualStyleBackColor = true;
            this.buttonExecutarTeste.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTeste
            // 
            this.labelTeste.AutoSize = true;
            this.labelTeste.Location = new System.Drawing.Point(27, 192);
            this.labelTeste.Name = "labelTeste";
            this.labelTeste.Size = new System.Drawing.Size(34, 13);
            this.labelTeste.TabIndex = 5;
            this.labelTeste.Text = "Teste";
            // 
            // labelSelecionarTeste2
            // 
            this.labelSelecionarTeste2.AutoSize = true;
            this.labelSelecionarTeste2.Location = new System.Drawing.Point(6, 16);
            this.labelSelecionarTeste2.Name = "labelSelecionarTeste2";
            this.labelSelecionarTeste2.Size = new System.Drawing.Size(96, 13);
            this.labelSelecionarTeste2.TabIndex = 6;
            this.labelSelecionarTeste2.Text = "Selecione o Teste:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSelecionarTeste1);
            this.groupBox2.Controls.Add(this.comboBoxLista1);
            this.groupBox2.Location = new System.Drawing.Point(192, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 74);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCarregarDefault);
            this.groupBox3.Controls.Add(this.buttonSalvarDados);
            this.groupBox3.Controls.Add(this.comboBoxLista2);
            this.groupBox3.Controls.Add(this.labelSelecionarTeste2);
            this.groupBox3.Location = new System.Drawing.Point(195, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 72);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonExecutarTeste);
            this.groupBox4.Location = new System.Drawing.Point(12, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 72);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // toolTipSalvar
            // 
            this.toolTipSalvar.IsBalloon = true;
            this.toolTipSalvar.OwnerDraw = true;
            // 
            // buttonCarregarDefault
            // 
            this.buttonCarregarDefault.BackgroundImage = global::treino.Properties.Resources.Default_Icon_icon;
            this.buttonCarregarDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCarregarDefault.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCarregarDefault.Location = new System.Drawing.Point(204, 33);
            this.buttonCarregarDefault.Name = "buttonCarregarDefault";
            this.buttonCarregarDefault.Size = new System.Drawing.Size(43, 25);
            this.buttonCarregarDefault.TabIndex = 8;
            this.toolTipSalvar.SetToolTip(this.buttonCarregarDefault, "Retorna aos valores Default(Padrão) dos Servidores DNS salvos");
            this.buttonCarregarDefault.UseVisualStyleBackColor = true;
            this.buttonCarregarDefault.Click += new System.EventHandler(this.buttonCarregarDefault_Click);
            // 
            // buttonSalvarDados
            // 
            this.buttonSalvarDados.BackgroundImage = global::treino.Properties.Resources.Save_37110;
            this.buttonSalvarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalvarDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSalvarDados.Location = new System.Drawing.Point(158, 33);
            this.buttonSalvarDados.Name = "buttonSalvarDados";
            this.buttonSalvarDados.Size = new System.Drawing.Size(40, 25);
            this.buttonSalvarDados.TabIndex = 7;
            this.toolTipSalvar.SetToolTip(this.buttonSalvarDados, "Personalizar Opçcoes de  Servidores DNS");
            this.buttonSalvarDados.UseVisualStyleBackColor = true;
            this.buttonSalvarDados.Click += new System.EventHandler(this.buttonSalvarDados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::treino.Properties.Resources.mini_banner;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Salvar Configuracoes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 172);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTeste);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(483, 210);
            this.MinimumSize = new System.Drawing.Size(483, 210);
            this.Name = "Form1";
            this.Text = "W4rL0ck! Utility Box";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLista1;
        private System.Windows.Forms.ComboBox comboBoxLista2;
        private System.Windows.Forms.Label labelSelecionarTeste1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExecutarTeste;
        private System.Windows.Forms.Label labelTeste;
        private System.Windows.Forms.Label labelSelecionarTeste2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalvarDados;
        private System.Windows.Forms.ToolTip toolTipSalvar;
        private System.Windows.Forms.Button buttonCarregarDefault;
    }
}

