namespace MatrixNome
{
    public partial class Form1 : Form
    {
        //         Variaveis:
        //==============================
        int idade = 0;
        string ano = "i";
        string nome = "i";
       



        //==============================
        public Form1()
        {
            InitializeComponent();
            picb_npode.Visible = false;
            picb_pode.Visible = false;
            lb_pode.Visible = false;
        }


     

          //Condições para ser Exibida cada tela
        private void bt_verificar_Click(object sender, EventArgs e)
        {
            
         
            
                if (tb_nasc.Text != "")
                {
                    idade = Convert.ToInt32(tb_nasc.Text);
                    ano = DateTime.Now.ToString("yyyy");
                    idade = int.Parse(ano) - idade;
                    nome = (tb_nome.Text + " " + tb_sobrenome.Text);
                }
                
              

                
            if (idade > 18)
            {
                
                lb_pode.Text = ("Ola Caro " + nome + "\n agora você pode ter \n Acesso ao conteudo \n obscuro da DeepWeb");
                bt_verificar.Visible = false;
                lb_pode.Visible = true;
                picb_pode.Visible=true;
                lb_verificar.Visible = false;
                pib_erro.Image = Properties.Resources.f4;
            }
            if (ano == "i")
            {
                MessageBox.Show("Você não colocou sua data de Nascimento \n Esta tentando quebrar o programa '-'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            if (idade < 18 && idade != 0)
            {
                lb_verificar.Visible = false;
                lb_npode.Visible = true;
                lb_npode.Text = ("Ola Caro "+ nome + "Você não tem idade  \n suficiente para poder acessar \n somente para maiores");
                picb_npode.Visible = true;
                picb_npode.Image = Properties.Resources.f5;
                
            }

        }

        //Botão de sair:
        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Botão de Limpar:
        private void button2_Click(object sender, EventArgs e)
        {
            idade = 0;
            ano = "";
            lb_verificar.Visible = true;
            bt_verificar.Visible = true;
            picb_npode.Visible = false;
            picb_pode.Visible = false;
            lb_pode.Visible=false;
            lb_npode.Visible=false;
            tb_nasc.Text = "";
            tb_nome.Text = "";
            tb_sobrenome.Text = "";
            pib_erro.Image = Properties.Resources.f3;
        }

        

        
    }
    
} 