using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.IO;

namespace treino
{
    public partial class Form2 : Form
    {
        Console Console1 = new Console();
        IniFile ini1 = new IniFile();

        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonSalvarDns_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();

            switch (comboBoxNomeDns.SelectedIndex)
            {
                case 0:
                    ini1.IniWriteString("ValorPing1", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping1", textBoxNomeServidor.Text.ToString());
                    break;
                case 1:
                    ini1.IniWriteString("ValorPing2", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping2", textBoxNomeServidor.Text.ToString());
                    break;
                case 2:
                    ini1.IniWriteString("ValorPing3", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping3", textBoxNomeServidor.Text.ToString());
                    break;
                case 3:
                    ini1.IniWriteString("ValorPing4", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping4", textBoxNomeServidor.Text.ToString());
                    break;
                case 4:
                    ini1.IniWriteString("ValorPing5", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping5", textBoxNomeServidor.Text.ToString());
                    break;
                case 5:
                    ini1.IniWriteString("ValorPing6", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping6", textBoxNomeServidor.Text.ToString());
                    break;
                case 6:
                    ini1.IniWriteString("ValorPing7", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping7", textBoxNomeServidor.Text.ToString());
                    break;
                case 7:
                    ini1.IniWriteString("ValorPing8", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping8", textBoxNomeServidor.Text.ToString());
                    break;
                case 8:
                    ini1.IniWriteString("ValorPing9", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping9", textBoxNomeServidor.Text.ToString());
                    break;
                case 9:
                    ini1.IniWriteString("ValorPing10", textBoxValor.Text.ToString());
                    ini1.IniWriteString("Ping10", textBoxNomeServidor.Text.ToString());
                    break;
            }

            this.Hide(); // esconde o form na hora em que o botao for executado!
            this.buttonSalvarDns.Visible = false; // esconde a visibilidade e o estado ativo do botao quando ele for
            this.buttonSalvarDns.Enabled = false;
            this.comboBoxNomeDns.Enabled = false;
            this.comboBoxNomeDns.Visible = false;
            this.textBoxNomeServidor.Enabled = false;
            this.textBoxNomeServidor.Visible = false ;
            this.textBoxValor.Text = "";
            NovoForm1.Show();

        }


        private void comboBoxNomeDns_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNomeDns.SelectedIndex)
            {
                case 0:
                    textBoxValor.Text = ini1.IniReadString("ValorPing1");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping1");
                    break;
                case 1:
                    textBoxValor.Text = ini1.IniReadString("ValorPing2");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping2");
                    break;
                case 2:
                    textBoxValor.Text = ini1.IniReadString("ValorPing3");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping3");
                    break;
                case 3:
                    textBoxValor.Text = ini1.IniReadString("ValorPing4");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping4");
                    break;
                case 4:
                    textBoxValor.Text = ini1.IniReadString("ValorPing5");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping5");
                    break;
                case 5:
                    textBoxValor.Text = ini1.IniReadString("ValorPing6");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping6");
                    break;
                case 6:
                    textBoxValor.Text = ini1.IniReadString("ValorPing7");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping7");
                    break;
                case 7:
                    textBoxValor.Text = ini1.IniReadString("ValorPing8");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping8");
                    break;
                case 8:
                    textBoxValor.Text = ini1.IniReadString("ValorPing9");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping9");
                    break;
                case 9:
                    textBoxValor.Text = ini1.IniReadString("ValorPing10");
                    textBoxNomeServidor.Text = ini1.IniReadString("Ping10");
                    break;
            }
        }

        private void buttonChecarDisco_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();
            Console1.valor = textBoxValor.Text;
            Process.Start("cmd.exe", Console1.ChecarDisco()).WaitForExit();
            this.Hide(); // esconde o form na hora em que o botao for executado!
            this.buttonChecarDisco.Visible = false;
            this.buttonChecarDisco.Enabled = false;
            this.textBoxValor.Text = "";
            NovoForm1.Show();
        }

        private void buttonConverterUnidade_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();
            Console1.valor = textBoxValor.Text;
            Process.Start("cmd.exe", Console1.ConverterUnidade()).WaitForExit();
            this.Hide(); // esconde o form na hora em que o botao for executado!
            this.buttonConverterUnidade.Visible = false;
            this.buttonConverterUnidade.Enabled = false;
            this.textBoxValor.Text = "";
            NovoForm1.Show();
        }

        private void buttonChecarMTU_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();
            Console1.valor = textBoxValor.Text;
            Process.Start("cmd.exe", Console1.MelhorMtu()).WaitForExit();
            this.buttonChecarMTU.Visible = false;
            this.buttonChecarMTU.Enabled = false;
            this.Hide();
            this.textBoxValor.Text = "";
            NovoForm1.Show();
        }

        private void buttonDesligamento_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();
            Console1.valor = textBoxValor.Text;
            Process.Start("cmd.exe", Console1.DesligarTempo());
            this.Hide(); // esconde o form na hora em que o botao for executado!
            this.buttonDesligamento.Visible = false; // esconde a visibilidade e o estado ativo do botao quando ele for
            this.buttonDesligamento.Enabled = false; // clicado! permitindo mais usos do programa.
            this.textBoxValor.Text = "";
            NovoForm1.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 NovoForm1 = new Form1();
            this.buttonDesligamento.Visible = false; // esconde a visibilidade e o estado ativo do botao quando ele for
            this.buttonDesligamento.Enabled = false;
            this.buttonChecarMTU.Visible = false;
            this.buttonChecarMTU.Enabled = false;
            this.buttonConverterUnidade.Visible = false;
            this.buttonConverterUnidade.Enabled = false;
            this.buttonConverterUnidade.Visible = false;
            this.buttonConverterUnidade.Enabled = false;
            this.buttonChecarDisco.Visible = false;
            this.buttonChecarDisco.Enabled = false;
            this.buttonSalvarDns.Visible = false; // esconde a visibilidade e o estado ativo do botao quando ele for
            this.buttonSalvarDns.Enabled = false;
            this.comboBoxNomeDns.Enabled = false;
            this.comboBoxNomeDns.Visible = false;
            this.textBoxNomeServidor.Enabled = false;
            this.textBoxNomeServidor.Visible = false;
            this.labelRetorno.Text = "";
            this.textBoxValor.Text = "";

            this.Hide();// esconde o form na hora em que o botao for executado!
            NovoForm1.Show();
        }
    }


}

