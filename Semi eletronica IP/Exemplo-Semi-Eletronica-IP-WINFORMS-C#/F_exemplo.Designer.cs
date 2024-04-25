namespace Integracao_Semi_Eletronica_IP_WINFORMS_C_
{
    partial class F_exemplo
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_salvarUsuario = new Button();
            tb_senha = new TextBox();
            tb_usuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btn_salvarIP = new Button();
            tb_porta = new TextBox();
            label4 = new Label();
            label3 = new Label();
            mtb_gateway = new MaskedTextBox();
            mtb_mascara = new MaskedTextBox();
            label2 = new Label();
            mtb_ip = new MaskedTextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tb_acionamento = new TextBox();
            btn_liberaSaida = new Button();
            btn_liberaEntrada = new Button();
            btn_liberaAmbos = new Button();
            label9 = new Label();
            btn_salvarAcionamento = new Button();
            label8 = new Label();
            cb_inverteGiro = new CheckBox();
            btn_salvarGiro = new Button();
            cb_saidaLiberada = new CheckBox();
            cb_entradaLiberada = new CheckBox();
            cb_ambasLiberadas = new CheckBox();
            cb_acessoDuplo = new CheckBox();
            cb_acessoUnico = new CheckBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            btn_salvarLimitador = new Button();
            tb_alerta = new TextBox();
            tb_limite = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cb_limitadorDeGiro = new CheckBox();
            label10 = new Label();
            rtb_log = new RichTextBox();
            btn_zerarLimitador = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 38, 92);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1093, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 628);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 0, 22);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1083, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 628);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 38, 92);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 628);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(227, 0, 22);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(30, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 628);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logorelsystem300x80;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(40, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1043, 80);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(40, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(743, 548);
            tabControl1.TabIndex = 4;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_salvarUsuario);
            tabPage1.Controls.Add(tb_senha);
            tabPage1.Controls.Add(tb_usuario);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btn_salvarIP);
            tabPage1.Controls.Add(tb_porta);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(mtb_gateway);
            tabPage1.Controls.Add(mtb_mascara);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(mtb_ip);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(735, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Configuração de IP";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_salvarUsuario
            // 
            btn_salvarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarUsuario.Location = new Point(254, 128);
            btn_salvarUsuario.Name = "btn_salvarUsuario";
            btn_salvarUsuario.Size = new Size(130, 30);
            btn_salvarUsuario.TabIndex = 13;
            btn_salvarUsuario.Text = "Salvar";
            btn_salvarUsuario.UseVisualStyleBackColor = true;
            btn_salvarUsuario.Click += btn_salvarUsuario_Click;
            // 
            // tb_senha
            // 
            tb_senha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_senha.Location = new Point(254, 93);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(130, 29);
            tb_senha.TabIndex = 12;
            tb_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_usuario
            // 
            tb_usuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_usuario.Location = new Point(254, 37);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(130, 29);
            tb_usuario.TabIndex = 11;
            tb_usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(254, 69);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 10;
            label6.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(254, 13);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 9;
            label5.Text = "Usuário:";
            // 
            // btn_salvarIP
            // 
            btn_salvarIP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarIP.Location = new Point(16, 240);
            btn_salvarIP.Name = "btn_salvarIP";
            btn_salvarIP.Size = new Size(130, 30);
            btn_salvarIP.TabIndex = 8;
            btn_salvarIP.Text = "Salvar";
            btn_salvarIP.UseVisualStyleBackColor = true;
            btn_salvarIP.Click += btn_salvarIP_Click;
            // 
            // tb_porta
            // 
            tb_porta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_porta.Location = new Point(16, 205);
            tb_porta.Name = "tb_porta";
            tb_porta.Size = new Size(130, 29);
            tb_porta.TabIndex = 7;
            tb_porta.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 181);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 6;
            label4.Text = "Porta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Gateway:";
            // 
            // mtb_gateway
            // 
            mtb_gateway.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtb_gateway.Location = new Point(16, 149);
            mtb_gateway.Mask = "000\\.000\\.000\\.000";
            mtb_gateway.Name = "mtb_gateway";
            mtb_gateway.Size = new Size(130, 29);
            mtb_gateway.TabIndex = 4;
            mtb_gateway.TextAlign = HorizontalAlignment.Center;
            mtb_gateway.ValidatingType = typeof(DateTime);
            // 
            // mtb_mascara
            // 
            mtb_mascara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtb_mascara.Location = new Point(16, 93);
            mtb_mascara.Mask = "000\\.000\\.000\\.000";
            mtb_mascara.Name = "mtb_mascara";
            mtb_mascara.Size = new Size(130, 29);
            mtb_mascara.TabIndex = 3;
            mtb_mascara.TextAlign = HorizontalAlignment.Center;
            mtb_mascara.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 69);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 2;
            label2.Text = "Máscara de sub-rede:";
            // 
            // mtb_ip
            // 
            mtb_ip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtb_ip.Location = new Point(16, 37);
            mtb_ip.Mask = "000\\.000\\.000\\.000";
            mtb_ip.Name = "mtb_ip";
            mtb_ip.Size = new Size(130, 29);
            mtb_ip.TabIndex = 1;
            mtb_ip.TextAlign = HorizontalAlignment.Center;
            mtb_ip.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tb_acionamento);
            tabPage2.Controls.Add(btn_liberaSaida);
            tabPage2.Controls.Add(btn_liberaEntrada);
            tabPage2.Controls.Add(btn_liberaAmbos);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btn_salvarAcionamento);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cb_inverteGiro);
            tabPage2.Controls.Add(btn_salvarGiro);
            tabPage2.Controls.Add(cb_saidaLiberada);
            tabPage2.Controls.Add(cb_entradaLiberada);
            tabPage2.Controls.Add(cb_ambasLiberadas);
            tabPage2.Controls.Add(cb_acessoDuplo);
            tabPage2.Controls.Add(cb_acessoUnico);
            tabPage2.Controls.Add(label7);
            tabPage2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(735, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Acionamento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_acionamento
            // 
            tb_acionamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_acionamento.Location = new Point(254, 48);
            tb_acionamento.Name = "tb_acionamento";
            tb_acionamento.Size = new Size(186, 29);
            tb_acionamento.TabIndex = 19;
            tb_acionamento.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_liberaSaida
            // 
            btn_liberaSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_liberaSaida.Location = new Point(254, 268);
            btn_liberaSaida.Name = "btn_liberaSaida";
            btn_liberaSaida.Size = new Size(186, 30);
            btn_liberaSaida.TabIndex = 18;
            btn_liberaSaida.Text = "Liberar Saída";
            btn_liberaSaida.UseVisualStyleBackColor = true;
            btn_liberaSaida.Click += btn_liberaSaida_Click;
            // 
            // btn_liberaEntrada
            // 
            btn_liberaEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_liberaEntrada.Location = new Point(254, 232);
            btn_liberaEntrada.Name = "btn_liberaEntrada";
            btn_liberaEntrada.Size = new Size(186, 30);
            btn_liberaEntrada.TabIndex = 17;
            btn_liberaEntrada.Text = "Liberar Entrada";
            btn_liberaEntrada.UseVisualStyleBackColor = true;
            btn_liberaEntrada.Click += btn_liberaEntrada_Click;
            // 
            // btn_liberaAmbos
            // 
            btn_liberaAmbos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_liberaAmbos.Location = new Point(254, 196);
            btn_liberaAmbos.Name = "btn_liberaAmbos";
            btn_liberaAmbos.Size = new Size(186, 30);
            btn_liberaAmbos.TabIndex = 16;
            btn_liberaAmbos.Text = "Liberar Ambos";
            btn_liberaAmbos.UseVisualStyleBackColor = true;
            btn_liberaAmbos.Click += btn_liberaAmbos_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(254, 172);
            label9.Name = "label9";
            label9.Size = new Size(143, 21);
            label9.TabIndex = 15;
            label9.Text = "Liberação de Giro:";
            // 
            // btn_salvarAcionamento
            // 
            btn_salvarAcionamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarAcionamento.Location = new Point(254, 83);
            btn_salvarAcionamento.Name = "btn_salvarAcionamento";
            btn_salvarAcionamento.Size = new Size(186, 30);
            btn_salvarAcionamento.TabIndex = 14;
            btn_salvarAcionamento.Text = "Salvar";
            btn_salvarAcionamento.UseVisualStyleBackColor = true;
            btn_salvarAcionamento.Click += btn_salvarAcionamento_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(254, 13);
            label8.Name = "label8";
            label8.Size = new Size(186, 21);
            label8.TabIndex = 11;
            label8.Text = "Tempo de acionamento:";
            // 
            // cb_inverteGiro
            // 
            cb_inverteGiro.AutoSize = true;
            cb_inverteGiro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_inverteGiro.Location = new Point(16, 237);
            cb_inverteGiro.Name = "cb_inverteGiro";
            cb_inverteGiro.Size = new Size(116, 25);
            cb_inverteGiro.TabIndex = 10;
            cb_inverteGiro.Text = "Inverte Giro";
            cb_inverteGiro.UseVisualStyleBackColor = true;
            // 
            // btn_salvarGiro
            // 
            btn_salvarGiro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarGiro.Location = new Point(16, 268);
            btn_salvarGiro.Name = "btn_salvarGiro";
            btn_salvarGiro.Size = new Size(153, 30);
            btn_salvarGiro.TabIndex = 9;
            btn_salvarGiro.Text = "Salvar";
            btn_salvarGiro.UseVisualStyleBackColor = true;
            btn_salvarGiro.Click += btn_salvarGiro_Click;
            // 
            // cb_saidaLiberada
            // 
            cb_saidaLiberada.AutoSize = true;
            cb_saidaLiberada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_saidaLiberada.Location = new Point(16, 191);
            cb_saidaLiberada.Name = "cb_saidaLiberada";
            cb_saidaLiberada.Size = new Size(135, 25);
            cb_saidaLiberada.TabIndex = 6;
            cb_saidaLiberada.Text = "Saída Liberada";
            cb_saidaLiberada.UseVisualStyleBackColor = true;
            // 
            // cb_entradaLiberada
            // 
            cb_entradaLiberada.AutoSize = true;
            cb_entradaLiberada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_entradaLiberada.Location = new Point(16, 160);
            cb_entradaLiberada.Name = "cb_entradaLiberada";
            cb_entradaLiberada.Size = new Size(151, 25);
            cb_entradaLiberada.TabIndex = 5;
            cb_entradaLiberada.Text = "Entrada Liberada";
            cb_entradaLiberada.UseVisualStyleBackColor = true;
            // 
            // cb_ambasLiberadas
            // 
            cb_ambasLiberadas.AutoSize = true;
            cb_ambasLiberadas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_ambasLiberadas.Location = new Point(16, 129);
            cb_ambasLiberadas.Name = "cb_ambasLiberadas";
            cb_ambasLiberadas.Size = new Size(153, 25);
            cb_ambasLiberadas.TabIndex = 4;
            cb_ambasLiberadas.Text = "Ambas Liberadas";
            cb_ambasLiberadas.UseVisualStyleBackColor = true;
            // 
            // cb_acessoDuplo
            // 
            cb_acessoDuplo.AutoSize = true;
            cb_acessoDuplo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_acessoDuplo.Location = new Point(16, 83);
            cb_acessoDuplo.Name = "cb_acessoDuplo";
            cb_acessoDuplo.Size = new Size(129, 25);
            cb_acessoDuplo.TabIndex = 3;
            cb_acessoDuplo.Text = "Acesso Duplo";
            cb_acessoDuplo.UseVisualStyleBackColor = true;
            // 
            // cb_acessoUnico
            // 
            cb_acessoUnico.AutoSize = true;
            cb_acessoUnico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_acessoUnico.Location = new Point(16, 52);
            cb_acessoUnico.Name = "cb_acessoUnico";
            cb_acessoUnico.Size = new Size(127, 25);
            cb_acessoUnico.TabIndex = 2;
            cb_acessoUnico.Text = "Acesso Único";
            cb_acessoUnico.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 13);
            label7.Name = "label7";
            label7.Size = new Size(128, 21);
            label7.TabIndex = 1;
            label7.Text = "Sentido de giro:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_zerarLimitador);
            tabPage3.Controls.Add(btn_salvarLimitador);
            tabPage3.Controls.Add(tb_alerta);
            tabPage3.Controls.Add(tb_limite);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(cb_limitadorDeGiro);
            tabPage3.Controls.Add(label10);
            tabPage3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(735, 518);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Limitador de Giro";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_salvarLimitador
            // 
            btn_salvarLimitador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarLimitador.Location = new Point(13, 203);
            btn_salvarLimitador.Name = "btn_salvarLimitador";
            btn_salvarLimitador.Size = new Size(130, 30);
            btn_salvarLimitador.TabIndex = 17;
            btn_salvarLimitador.Text = "Salvar";
            btn_salvarLimitador.UseVisualStyleBackColor = true;
            btn_salvarLimitador.Click += btn_salvarLimitador_Click;
            // 
            // tb_alerta
            // 
            tb_alerta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_alerta.Location = new Point(13, 168);
            tb_alerta.Name = "tb_alerta";
            tb_alerta.Size = new Size(130, 29);
            tb_alerta.TabIndex = 16;
            tb_alerta.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_limite
            // 
            tb_limite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_limite.Location = new Point(13, 112);
            tb_limite.Name = "tb_limite";
            tb_limite.Size = new Size(130, 29);
            tb_limite.TabIndex = 15;
            tb_limite.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 144);
            label11.Name = "label11";
            label11.Size = new Size(58, 21);
            label11.TabIndex = 14;
            label11.Text = "Alerta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(13, 88);
            label12.Name = "label12";
            label12.Size = new Size(59, 21);
            label12.TabIndex = 13;
            label12.Text = "Limite:";
            // 
            // cb_limitadorDeGiro
            // 
            cb_limitadorDeGiro.AutoSize = true;
            cb_limitadorDeGiro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_limitadorDeGiro.Location = new Point(13, 50);
            cb_limitadorDeGiro.Name = "cb_limitadorDeGiro";
            cb_limitadorDeGiro.Size = new Size(142, 25);
            cb_limitadorDeGiro.TabIndex = 3;
            cb_limitadorDeGiro.Text = "Ativa / Desativa";
            cb_limitadorDeGiro.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 13);
            label10.Name = "label10";
            label10.Size = new Size(141, 21);
            label10.TabIndex = 2;
            label10.Text = "Limitador de giro:";
            // 
            // rtb_log
            // 
            rtb_log.BackColor = Color.FromArgb(42, 48, 54);
            rtb_log.Dock = DockStyle.Right;
            rtb_log.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rtb_log.ForeColor = Color.White;
            rtb_log.Location = new Point(783, 80);
            rtb_log.Name = "rtb_log";
            rtb_log.ReadOnly = true;
            rtb_log.Size = new Size(300, 548);
            rtb_log.TabIndex = 5;
            rtb_log.Text = "";
            // 
            // btn_zerarLimitador
            // 
            btn_zerarLimitador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_zerarLimitador.Location = new Point(13, 239);
            btn_zerarLimitador.Name = "btn_zerarLimitador";
            btn_zerarLimitador.Size = new Size(130, 30);
            btn_zerarLimitador.TabIndex = 18;
            btn_zerarLimitador.Text = "Zerar Limitador";
            btn_zerarLimitador.UseVisualStyleBackColor = true;
            btn_zerarLimitador.Click += btn_zerarLimitador_Click;
            // 
            // F_exemplo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 628);
            Controls.Add(tabControl1);
            Controls.Add(rtb_log);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "F_exemplo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exemplo Integração Semi Eletrônica IP - RELSYSTEM";
            Load += F_exemplo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MaskedTextBox mtb_ip;
        private Label label1;
        private TextBox tb_porta;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtb_gateway;
        private MaskedTextBox mtb_mascara;
        private Label label2;
        private RichTextBox rtb_log;
        private Button btn_salvarIP;
        private Button btn_salvarUsuario;
        private TextBox tb_senha;
        private TextBox tb_usuario;
        private Label label6;
        private Label label5;
        private CheckBox cb_saidaLiberada;
        private CheckBox cb_entradaLiberada;
        private CheckBox cb_ambasLiberadas;
        private CheckBox cb_acessoDuplo;
        private CheckBox cb_acessoUnico;
        private Label label7;
        private CheckBox cb_inverteGiro;
        private Button btn_salvarGiro;
        private Button btn_salvarAcionamento;
        private TextBox recebeAcionamento;
        private Label label8;
        private Button btn_liberaSaida;
        private Button btn_liberaEntrada;
        private Button btn_liberaAmbos;
        private Label label9;
        private CheckBox cb_limitadorDeGiro;
        private Label label10;
        private Button btn_salvarLimitador;
        private TextBox tb_alerta;
        private TextBox tb_limite;
        private Label label11;
        private Label label12;
        private TextBox tb_acionamento;
        private Button btn_zerarLimitador;
    }
}
