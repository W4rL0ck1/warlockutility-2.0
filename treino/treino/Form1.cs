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
    public partial class Form1 : Form
    {
        Console Console1 = new Console();
        IniFile ini1 = new IniFile();
        Form2 NovoForm2 = new Form2();
        string NovoItem;
        string NovoItem1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux1 = ini1.IniReadString("Ping1");
            string aux2 = ini1.IniReadString("Ping2");
            string aux3 = ini1.IniReadString("Ping3");
            string aux4 = ini1.IniReadString("Ping4");
            string aux5 = ini1.IniReadString("Ping5");
            string aux6 = ini1.IniReadString("Ping6");
            string aux7 = ini1.IniReadString("Ping7");
            string aux8 = ini1.IniReadString("Ping8");
            string aux9 = ini1.IniReadString("Ping9");
            string aux10 = ini1.IniReadString("Ping10");
            string aux11 = ini1.IniReadString("ValorPing1");
            string aux12 = ini1.IniReadString("ValorPing2");
            string aux13 = ini1.IniReadString("ValorPing3");
            string aux14 = ini1.IniReadString("ValorPing4");
            string aux15 = ini1.IniReadString("ValorPing5");
            string aux16 = ini1.IniReadString("ValorPing6");
            string aux17 = ini1.IniReadString("ValorPing7");
            string aux18 = ini1.IniReadString("ValorPing8");
            string aux19 = ini1.IniReadString("ValorPing9");
            string aux20 = ini1.IniReadString("ValorPing10");


            if (NovoItem1 == aux1)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux11)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux2)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux12)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux3)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux13)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux4)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux14)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux5)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux15)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux6)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux16)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux7)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux17)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux8)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux18)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux9)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux19)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == aux10)
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.PingUsuario(aux20)).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "Remover IP")
            {
                this.Hide();
                MessageBox.Show("Esta opçao irá remover o endereco IP da sua maquina e poderá acarretar problemas de rede\n Use a opçao Renovar IP para forcar uma renovao do seu endereço caso seu roteador esteja apresentando problemas de conexao de novos usuarios na rede");
                Process.Start("cmd.exe", Console1.remover_ip).WaitForExit();             
                this.Show();
            }           
            if (NovoItem1 == "Renovar IP")
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.renovar_ip).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "IP Config")
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.ip_config).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "Desligar Windows Com Tempo")
            {
                NovoForm2.Show();
                //Process.Start("cmd.exe", Console1.DesligarTempo()).WaitForExit();
                NovoForm2.labelRetorno.Text = "Digite o valor em\n segundos p/ o\n desligamento \n3600 = 1 HORA!";
                NovoForm2.buttonDesligamento.Visible = true;
                NovoForm2.buttonDesligamento.Enabled = true;
                MessageBox.Show("Insira um valor em segundos\n Para o Timer de desligamento do Windows!");
                this.Hide();
            }
            if (NovoItem1 == "Interromper Desligamento")
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.interromper_desligamento).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "Checar o Disco e Reparar Setores")
            {
                NovoForm2.Show();
                //Process.Start("cmd.exe", Console1.ChecarDisco()).WaitForExit();
                NovoForm2.labelRetorno.Text = "INSIRA A LETRA\n DA UNIDADE DO DISCO\n QUE DESEJA VERIFICAR:";
                NovoForm2.buttonChecarDisco.Visible = true;
                NovoForm2.buttonChecarDisco.Enabled = true;
                MessageBox.Show("Selecione o Disco que deseja verificar, O sistema irá varrer o disco procurando por erros e tentará corrigi-los! Por Favor Aguarde a conclusão do processo!O mesmo poderá levar um tempo!Pressione Ok para continuar!");
                this.Hide();
            }
            if (NovoItem1 == "Verificar Erros no Windows")
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.verificar_erros_win).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "Limpar Arquivos Temporarios")
            {
                this.Hide();
                Process.Start("cmd.exe", Console1.limpar_arquivos_temp).WaitForExit();
                this.Show();
            }
            if (NovoItem1 == "Converter Unidade FAT para NTFS")
            {
                NovoForm2.Show();
                //Process.Start("cmd.exe", Console1.ConverterUnidade()).WaitForExit();               
                NovoForm2.labelRetorno.Text = "INSIRA A LETRA DA\nUNIDADE DO DISPOSITIVO\nQUE DESEJA CONVERTER!";
                NovoForm2.buttonConverterUnidade.Visible = true;
                NovoForm2.buttonConverterUnidade.Enabled = true;
                MessageBox.Show("Todos os Dados do dispositivo convertido serão excluidos! Cuidado ao Utilizar esta função!");
                this.Hide();
            }
            if (NovoItem1 == "ChecarMTU")
            {
                NovoForm2.Show();
                NovoForm2.buttonChecarMTU.Visible = true;
                NovoForm2.buttonChecarMTU.Enabled = true;
                NovoForm2.labelRetorno.Text = "Insira valor de MTU"; // Environment.NewLine pula uma linha assim como "\n"
                //Process.Start("cmd.exe", Console1.MelhorMtu()).WaitForExit();
                MessageBox.Show("Teste o melhor valor de MTU para seu Roteador!" + Environment.NewLine + Environment.NewLine + "Comece com o valor de 1500 e Caso apareça a mensagem:" + Environment.NewLine + "--- O pacote precisa ser fragmentado, mas a desfragmentação está ativa---" + Environment.NewLine + Environment.NewLine + "Repita o processo diminuindo de dez em dez o valor de MTU até que o mesmo apresente resposta!");
                this.Hide();
            }
        }

        private void comboBoxLista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* esta seçao irá compor a primeira lista de itens principais , caso precise adicionar algum item ao mesmo 
            adicione na opcao "colecao do comboboxlista1", e adicione um laço abaixo com o mesmo do item adicionado e seus items 
            conforme os exemplos abaixo           
             */

            NovoItem = ((ComboBox)sender).SelectedItem.ToString();
            
            if (NovoItem == "Testes de Latencia")
            {
                comboBoxLista2.Items.Clear();
                comboBoxLista2.Items.AddRange(new object[] { ini1.IniReadString("Ping1"), ini1.IniReadString("Ping2"), ini1.IniReadString("Ping3"), ini1.IniReadString("Ping4"), ini1.IniReadString("Ping5"), ini1.IniReadString("Ping6"), ini1.IniReadString("Ping7"), ini1.IniReadString("Ping8"), ini1.IniReadString("Ping9"), ini1.IniReadString("Ping10") });
            }
            if (NovoItem == "Manutenção de IP")
            {
                comboBoxLista2.Items.Clear();
                comboBoxLista2.Items.AddRange(new object[] { "Remover IP","Renovar IP", "IP Config"});
            }
            if (NovoItem == "Desligamento do Windows por Tempo")
            {
                comboBoxLista2.Items.Clear();
                comboBoxLista2.Items.AddRange(new object[] { "Desligar Windows Com Tempo", "Interromper Desligamento"});
            }
            if (NovoItem == "Outros")
            {
                comboBoxLista2.Items.Clear();
                comboBoxLista2.Items.AddRange(new object[] { "Checar o Disco e Reparar Setores", "Verificar Erros no Windows", "Limpar Arquivos Temporarios", "Converter Unidade FAT para NTFS", "ChecarMTU", "Mostrar Horario" });
            }
        }

        private void comboBoxLista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            NovoItem1 = comboBoxLista2.SelectedItem.ToString();
        }

        private void buttonSalvarDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            NovoForm2.Show();
            //NovoForm2.textBoxDns.Text = "Nome do Servidor DNS";
            NovoForm2.textBoxValor.Text = "0.0.0.0";
            NovoForm2.textBoxNomeServidor.Text = "Nome do Servidor DNS";
            NovoForm2.buttonSalvarDns.Visible = true;
            NovoForm2.buttonSalvarDns.Enabled = true;
            NovoForm2.comboBoxNomeDns.Enabled = true;
            NovoForm2.comboBoxNomeDns.Visible = true;
            NovoForm2.textBoxNomeServidor.Enabled = true;
            NovoForm2.textBoxNomeServidor.Visible = true;
            NovoForm2.comboBoxNomeDns.Items.Clear();
            NovoForm2.comboBoxNomeDns.Items.AddRange(new object[] { ini1.IniReadString("Ping1"), ini1.IniReadString("Ping2"), ini1.IniReadString("Ping3"), ini1.IniReadString("Ping4"), ini1.IniReadString("Ping5"), ini1.IniReadString("Ping6"), ini1.IniReadString("Ping7"), ini1.IniReadString("Ping8"), ini1.IniReadString("Ping9"), ini1.IniReadString("Ping10") });
        }

        private void buttonCarregarDefault_Click(object sender, EventArgs e)
        {
            //reseta os nomes dos servidores dns salvos para o padrao.
            ini1.IniWriteString("Ping1", "Google");
            ini1.IniWriteString("Ping2", "Cloudflare");
            ini1.IniWriteString("Ping3", "Rooters");
            ini1.IniWriteString("Ping4", "Ping4");
            ini1.IniWriteString("Ping5", "Ping5");
            ini1.IniWriteString("Ping6", "Ping6");
            ini1.IniWriteString("Ping7", "Ping7");
            ini1.IniWriteString("Ping8", "Ping8");
            ini1.IniWriteString("Ping9", "Ping9");
            ini1.IniWriteString("Ping10", "Ping10");
            //reseta os enderecos dos servidores dns salvos para o padrao.
            ini1.IniWriteString("ValorPing1", "8.8.8.8");
            ini1.IniWriteString("ValorPing2", "1.1.1.1");
            ini1.IniWriteString("ValorPing3", "192.168.0.1");
            ini1.IniWriteString("ValorPing4", "0.0.0.0");
            ini1.IniWriteString("ValorPing5", "0.0.0.0");
            ini1.IniWriteString("ValorPing6", "0.0.0.0");
            ini1.IniWriteString("ValorPing7", "0.0.0.0");
            ini1.IniWriteString("ValorPing8", "0.0.0.0");
            ini1.IniWriteString("ValorPing9", "0.0.0.0");
            ini1.IniWriteString("ValorPing10", "0.0.0.0");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // confirma que ao ser clicado o botao de sair pelo usuario toda a aplicacao sera encerrada!            
        }
    }
}  
