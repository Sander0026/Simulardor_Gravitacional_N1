namespace Simulardor_Gravitacional_N1
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
            pn_Controle = new Panel();
            Qtd_Corpos_Box = new TextBox();
            Qtd_Corpos_Label = new Label();
            pn_Simulacao = new Panel();
            Qtd_Corpos_Atual_Box = new TextBox();
            Qtd_Corpos_Atual_Label = new Label();
            Num_Interacoes_Box = new TextBox();
            Num_Interacoes_Label = new Label();
            Tempo_Entre_Interacoes_Box = new TextBox();
            Tempo_Entre_Interacoes_Label = new Label();
            Massa_Minima_Box = new TextBox();
            Massa_Minima_Label = new Label();
            Massa_Maxima_Box = new TextBox();
            Massa_Maxima_Label = new Label();
            Proporcao_Box = new TextBox();
            Proporcao_Label = new Label();
            btn_Aleatorio = new Button();
            btn_Executar = new Button();
            btn_Gravar = new Button();
            btn_Gravar_Configuracao_inicial = new Button();
            btn_Carregar_Simulacao = new Button();
            pn_Controle.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Controle
            // 
            pn_Controle.Controls.Add(btn_Carregar_Simulacao);
            pn_Controle.Controls.Add(btn_Gravar_Configuracao_inicial);
            pn_Controle.Controls.Add(btn_Gravar);
            pn_Controle.Controls.Add(btn_Executar);
            pn_Controle.Controls.Add(btn_Aleatorio);
            pn_Controle.Controls.Add(Proporcao_Box);
            pn_Controle.Controls.Add(Proporcao_Label);
            pn_Controle.Controls.Add(Massa_Maxima_Box);
            pn_Controle.Controls.Add(Massa_Maxima_Label);
            pn_Controle.Controls.Add(Massa_Minima_Box);
            pn_Controle.Controls.Add(Massa_Minima_Label);
            pn_Controle.Controls.Add(Tempo_Entre_Interacoes_Box);
            pn_Controle.Controls.Add(Tempo_Entre_Interacoes_Label);
            pn_Controle.Controls.Add(Num_Interacoes_Box);
            pn_Controle.Controls.Add(Num_Interacoes_Label);
            pn_Controle.Controls.Add(Qtd_Corpos_Atual_Box);
            pn_Controle.Controls.Add(Qtd_Corpos_Atual_Label);
            pn_Controle.Controls.Add(Qtd_Corpos_Box);
            pn_Controle.Controls.Add(Qtd_Corpos_Label);
            pn_Controle.Dock = DockStyle.Right;
            pn_Controle.Location = new Point(1310, 0);
            pn_Controle.Name = "pn_Controle";
            pn_Controle.Size = new Size(201, 647);
            pn_Controle.TabIndex = 0;
            // 
            // Qtd_Corpos_Box
            // 
            Qtd_Corpos_Box.Location = new Point(31, 34);
            Qtd_Corpos_Box.Name = "Qtd_Corpos_Box";
            Qtd_Corpos_Box.Size = new Size(131, 23);
            Qtd_Corpos_Box.TabIndex = 1;
            // 
            // Qtd_Corpos_Label
            // 
            Qtd_Corpos_Label.AutoSize = true;
            Qtd_Corpos_Label.Location = new Point(31, 16);
            Qtd_Corpos_Label.Name = "Qtd_Corpos_Label";
            Qtd_Corpos_Label.Size = new Size(71, 15);
            Qtd_Corpos_Label.TabIndex = 0;
            Qtd_Corpos_Label.Text = "Qtd. Corpos";
            // 
            // pn_Simulacao
            // 
            pn_Simulacao.BackColor = Color.Black;
            pn_Simulacao.Location = new Point(3, 0);
            pn_Simulacao.Name = "pn_Simulacao";
            pn_Simulacao.Size = new Size(1301, 647);
            pn_Simulacao.TabIndex = 1;
            // 
            // Qtd_Corpos_Atual_Box
            // 
            Qtd_Corpos_Atual_Box.Enabled = false;
            Qtd_Corpos_Atual_Box.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Qtd_Corpos_Atual_Box.Location = new Point(31, 78);
            Qtd_Corpos_Atual_Box.Name = "Qtd_Corpos_Atual_Box";
            Qtd_Corpos_Atual_Box.Size = new Size(131, 27);
            Qtd_Corpos_Atual_Box.TabIndex = 3;
            // 
            // Qtd_Corpos_Atual_Label
            // 
            Qtd_Corpos_Atual_Label.AutoSize = true;
            Qtd_Corpos_Atual_Label.Location = new Point(31, 60);
            Qtd_Corpos_Atual_Label.Name = "Qtd_Corpos_Atual_Label";
            Qtd_Corpos_Atual_Label.Size = new Size(102, 15);
            Qtd_Corpos_Atual_Label.TabIndex = 2;
            Qtd_Corpos_Atual_Label.Text = "Qtd. Corpos Atual";
            // 
            // Num_Interacoes_Box
            // 
            Num_Interacoes_Box.Location = new Point(31, 122);
            Num_Interacoes_Box.Name = "Num_Interacoes_Box";
            Num_Interacoes_Box.Size = new Size(131, 23);
            Num_Interacoes_Box.TabIndex = 5;
            // 
            // Num_Interacoes_Label
            // 
            Num_Interacoes_Label.AutoSize = true;
            Num_Interacoes_Label.Location = new Point(31, 104);
            Num_Interacoes_Label.Name = "Num_Interacoes_Label";
            Num_Interacoes_Label.Size = new Size(94, 15);
            Num_Interacoes_Label.TabIndex = 4;
            Num_Interacoes_Label.Text = "Num. Interações";
            // 
            // Tempo_Entre_Interacoes_Box
            // 
            Tempo_Entre_Interacoes_Box.Location = new Point(31, 166);
            Tempo_Entre_Interacoes_Box.Name = "Tempo_Entre_Interacoes_Box";
            Tempo_Entre_Interacoes_Box.Size = new Size(131, 23);
            Tempo_Entre_Interacoes_Box.TabIndex = 7;
            // 
            // Tempo_Entre_Interacoes_Label
            // 
            Tempo_Entre_Interacoes_Label.AutoSize = true;
            Tempo_Entre_Interacoes_Label.Location = new Point(31, 148);
            Tempo_Entre_Interacoes_Label.Name = "Tempo_Entre_Interacoes_Label";
            Tempo_Entre_Interacoes_Label.Size = new Size(131, 15);
            Tempo_Entre_Interacoes_Label.TabIndex = 6;
            Tempo_Entre_Interacoes_Label.Text = "Tempo Entre Interações";
            // 
            // Massa_Minima_Box
            // 
            Massa_Minima_Box.Location = new Point(31, 210);
            Massa_Minima_Box.Name = "Massa_Minima_Box";
            Massa_Minima_Box.Size = new Size(131, 23);
            Massa_Minima_Box.TabIndex = 9;
            // 
            // Massa_Minima_Label
            // 
            Massa_Minima_Label.AutoSize = true;
            Massa_Minima_Label.Location = new Point(31, 192);
            Massa_Minima_Label.Name = "Massa_Minima_Label";
            Massa_Minima_Label.Size = new Size(84, 15);
            Massa_Minima_Label.TabIndex = 8;
            Massa_Minima_Label.Text = "Massa Minima";
            // 
            // Massa_Maxima_Box
            // 
            Massa_Maxima_Box.Location = new Point(31, 254);
            Massa_Maxima_Box.Name = "Massa_Maxima_Box";
            Massa_Maxima_Box.Size = new Size(131, 23);
            Massa_Maxima_Box.TabIndex = 11;
            // 
            // Massa_Maxima_Label
            // 
            Massa_Maxima_Label.AutoSize = true;
            Massa_Maxima_Label.Location = new Point(31, 236);
            Massa_Maxima_Label.Name = "Massa_Maxima_Label";
            Massa_Maxima_Label.Size = new Size(85, 15);
            Massa_Maxima_Label.TabIndex = 10;
            Massa_Maxima_Label.Text = "Massa Maxima";
            // 
            // Proporcao_Box
            // 
            Proporcao_Box.Enabled = false;
            Proporcao_Box.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Proporcao_Box.Location = new Point(31, 298);
            Proporcao_Box.Name = "Proporcao_Box";
            Proporcao_Box.Size = new Size(131, 27);
            Proporcao_Box.TabIndex = 13;
            // 
            // Proporcao_Label
            // 
            Proporcao_Label.AutoSize = true;
            Proporcao_Label.Location = new Point(31, 280);
            Proporcao_Label.Name = "Proporcao_Label";
            Proporcao_Label.Size = new Size(62, 15);
            Proporcao_Label.TabIndex = 12;
            Proporcao_Label.Text = "Proporção";
            // 
            // btn_Aleatorio
            // 
            btn_Aleatorio.Location = new Point(16, 388);
            btn_Aleatorio.Name = "btn_Aleatorio";
            btn_Aleatorio.Size = new Size(170, 23);
            btn_Aleatorio.TabIndex = 14;
            btn_Aleatorio.Text = "Aleatório";
            btn_Aleatorio.UseVisualStyleBackColor = true;
            // 
            // btn_Executar
            // 
            btn_Executar.Location = new Point(14, 427);
            btn_Executar.Name = "btn_Executar";
            btn_Executar.Size = new Size(172, 23);
            btn_Executar.TabIndex = 15;
            btn_Executar.Text = "Executar";
            btn_Executar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            btn_Gravar.Location = new Point(16, 469);
            btn_Gravar.Name = "btn_Gravar";
            btn_Gravar.Size = new Size(170, 23);
            btn_Gravar.TabIndex = 16;
            btn_Gravar.Text = "Gravar";
            btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar_Configuracao_inicial
            // 
            btn_Gravar_Configuracao_inicial.Location = new Point(16, 509);
            btn_Gravar_Configuracao_inicial.Name = "btn_Gravar_Configuracao_inicial";
            btn_Gravar_Configuracao_inicial.Size = new Size(170, 23);
            btn_Gravar_Configuracao_inicial.TabIndex = 17;
            btn_Gravar_Configuracao_inicial.Text = "Gravar Configuração Inicial";
            btn_Gravar_Configuracao_inicial.UseVisualStyleBackColor = true;
            // 
            // btn_Carregar_Simulacao
            // 
            btn_Carregar_Simulacao.Location = new Point(14, 547);
            btn_Carregar_Simulacao.Name = "btn_Carregar_Simulacao";
            btn_Carregar_Simulacao.Size = new Size(172, 23);
            btn_Carregar_Simulacao.TabIndex = 18;
            btn_Carregar_Simulacao.Text = "Carregar Simulação";
            btn_Carregar_Simulacao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 647);
            Controls.Add(pn_Simulacao);
            Controls.Add(pn_Controle);
            Name = "Form1";
            Text = "Form1";
            pn_Controle.ResumeLayout(false);
            pn_Controle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Controle;
        private Panel pn_Simulacao;
        private TextBox Qtd_Corpos_Box;
        private Label Qtd_Corpos_Label;
        private TextBox Proporcao_Box;
        private Label Proporcao_Label;
        private TextBox Massa_Maxima_Box;
        private Label Massa_Maxima_Label;
        private TextBox Massa_Minima_Box;
        private Label Massa_Minima_Label;
        private TextBox Tempo_Entre_Interacoes_Box;
        private Label Tempo_Entre_Interacoes_Label;
        private TextBox Num_Interacoes_Box;
        private Label Num_Interacoes_Label;
        private TextBox Qtd_Corpos_Atual_Box;
        private Label Qtd_Corpos_Atual_Label;
        private Button btn_Aleatorio;
        private Button btn_Carregar_Simulacao;
        private Button btn_Gravar_Configuracao_inicial;
        private Button btn_Gravar;
        private Button btn_Executar;
    }
}
