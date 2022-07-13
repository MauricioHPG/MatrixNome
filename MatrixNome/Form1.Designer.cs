namespace MatrixNome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_verificar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_npode = new System.Windows.Forms.Label();
            this.lb_pode = new System.Windows.Forms.Label();
            this.picb_pode = new System.Windows.Forms.PictureBox();
            this.picb_npode = new System.Windows.Forms.PictureBox();
            this.pib_erro = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_verificar = new System.Windows.Forms.Button();
            this.tb_nasc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_npode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_erro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lb_verificar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 439);
            this.panel1.TabIndex = 0;
            // 
            // lb_verificar
            // 
            this.lb_verificar.AutoSize = true;
            this.lb_verificar.BackColor = System.Drawing.Color.Black;
            this.lb_verificar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_verificar.ForeColor = System.Drawing.Color.Lime;
            this.lb_verificar.Location = new System.Drawing.Point(78, 106);
            this.lb_verificar.Name = "lb_verificar";
            this.lb_verificar.Size = new System.Drawing.Size(105, 25);
            this.lb_verificar.TabIndex = 0;
            this.lb_verificar.Text = "Verificador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_npode);
            this.panel2.Controls.Add(this.lb_pode);
            this.panel2.Controls.Add(this.picb_pode);
            this.panel2.Controls.Add(this.picb_npode);
            this.panel2.Controls.Add(this.pib_erro);
            this.panel2.Controls.Add(this.sair);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.bt_verificar);
            this.panel2.Controls.Add(this.tb_nasc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_nome);
            this.panel2.Controls.Add(this.tb_sobrenome);
            this.panel2.Controls.Add(this.tb_nome);
            this.panel2.Location = new System.Drawing.Point(58, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 301);
            this.panel2.TabIndex = 1;
            // 
            // lb_npode
            // 
            this.lb_npode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_npode.AutoSize = true;
            this.lb_npode.BackColor = System.Drawing.Color.Transparent;
            this.lb_npode.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_npode.ForeColor = System.Drawing.Color.Red;
            this.lb_npode.Location = new System.Drawing.Point(0, 0);
            this.lb_npode.Name = "lb_npode";
            this.lb_npode.Size = new System.Drawing.Size(0, 17);
            this.lb_npode.TabIndex = 13;
            // 
            // lb_pode
            // 
            this.lb_pode.AutoSize = true;
            this.lb_pode.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_pode.ForeColor = System.Drawing.Color.Lime;
            this.lb_pode.Location = new System.Drawing.Point(18, 66);
            this.lb_pode.Name = "lb_pode";
            this.lb_pode.Size = new System.Drawing.Size(0, 17);
            this.lb_pode.TabIndex = 2;
            // 
            // picb_pode
            // 
            this.picb_pode.BackColor = System.Drawing.Color.Transparent;
            this.picb_pode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picb_pode.Image = global::MatrixNome.Properties.Resources.f3;
            this.picb_pode.ImageLocation = "";
            this.picb_pode.Location = new System.Drawing.Point(3, 38);
            this.picb_pode.Name = "picb_pode";
            this.picb_pode.Size = new System.Drawing.Size(208, 179);
            this.picb_pode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_pode.TabIndex = 12;
            this.picb_pode.TabStop = false;
            // 
            // picb_npode
            // 
            this.picb_npode.BackColor = System.Drawing.Color.Transparent;
            this.picb_npode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picb_npode.Image = global::MatrixNome.Properties.Resources.f3;
            this.picb_npode.ImageLocation = "";
            this.picb_npode.Location = new System.Drawing.Point(8, 3);
            this.picb_npode.Name = "picb_npode";
            this.picb_npode.Size = new System.Drawing.Size(404, 241);
            this.picb_npode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_npode.TabIndex = 11;
            this.picb_npode.TabStop = false;
            // 
            // pib_erro
            // 
            this.pib_erro.BackColor = System.Drawing.Color.Transparent;
            this.pib_erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pib_erro.Image = global::MatrixNome.Properties.Resources.f3;
            this.pib_erro.ImageLocation = "";
            this.pib_erro.Location = new System.Drawing.Point(217, 38);
            this.pib_erro.Name = "pib_erro";
            this.pib_erro.Size = new System.Drawing.Size(173, 179);
            this.pib_erro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pib_erro.TabIndex = 10;
            this.pib_erro.TabStop = false;
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sair.ForeColor = System.Drawing.Color.Crimson;
            this.sair.Location = new System.Drawing.Point(270, 245);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(120, 40);
            this.sair.TabIndex = 9;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(144, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_verificar
            // 
            this.bt_verificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_verificar.ForeColor = System.Drawing.Color.Crimson;
            this.bt_verificar.Location = new System.Drawing.Point(18, 245);
            this.bt_verificar.Name = "bt_verificar";
            this.bt_verificar.Size = new System.Drawing.Size(120, 40);
            this.bt_verificar.TabIndex = 7;
            this.bt_verificar.Text = "Verificar";
            this.bt_verificar.UseVisualStyleBackColor = true;
            this.bt_verificar.Click += new System.EventHandler(this.bt_verificar_Click);
            // 
            // tb_nasc
            // 
            this.tb_nasc.Location = new System.Drawing.Point(115, 190);
            this.tb_nasc.Name = "tb_nasc";
            this.tb_nasc.Size = new System.Drawing.Size(71, 27);
            this.tb_nasc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano Nasc.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.ForeColor = System.Drawing.Color.Lime;
            this.lb_nome.Location = new System.Drawing.Point(18, 38);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(63, 25);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.Text = "Nome";
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Location = new System.Drawing.Point(18, 134);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(168, 27);
            this.tb_sobrenome.TabIndex = 1;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(18, 66);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(168, 27);
            this.tb_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = " Enter the Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_npode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_erro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lb_verificar;
        private Label label1;
        private TextBox tb_nasc;
        private Label label5;
        private Label label4;
        private Label lb_nome;
        private TextBox tb_sobrenome;
        private TextBox tb_nome;
        private Button sair;
        private Button button2;
        private Button bt_verificar;
        private PictureBox pib_erro;
        private PictureBox picb_npode;
        private PictureBox picb_pode;
        private Label lb_pode;
        private Label lb_npode;
    }
}