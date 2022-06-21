
namespace JogoDaForca.Ui
{
    partial class FormJogoDaForca
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
            this.pnJogo = new System.Windows.Forms.Panel();
            this.gbDica = new System.Windows.Forms.GroupBox();
            this.lbDica = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gbTentativasRestantes = new System.Windows.Forms.GroupBox();
            this.lbseparador = new System.Windows.Forms.Label();
            this.lbTentativas = new System.Windows.Forms.Label();
            this.lbJogadas = new System.Windows.Forms.Label();
            this.TbPalavraSecreta = new System.Windows.Forms.TextBox();
            this.lbpalavraSecreta = new System.Windows.Forms.Label();
            this.btnHerois = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbLetrasDigitadas = new System.Windows.Forms.TextBox();
            this.lbLetrasDigitadas = new System.Windows.Forms.Label();
            this.pnJogo.SuspendLayout();
            this.gbDica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTentativasRestantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnJogo
            // 
            this.pnJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnJogo.Controls.Add(this.tbLetrasDigitadas);
            this.pnJogo.Controls.Add(this.lbLetrasDigitadas);
            this.pnJogo.Controls.Add(this.gbDica);
            this.pnJogo.Controls.Add(this.groupBox1);
            this.pnJogo.Controls.Add(this.gbTentativasRestantes);
            this.pnJogo.Controls.Add(this.TbPalavraSecreta);
            this.pnJogo.Controls.Add(this.lbpalavraSecreta);
            this.pnJogo.Location = new System.Drawing.Point(0, 0);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(465, 296);
            this.pnJogo.TabIndex = 0;
            this.pnJogo.Visible = false;
            // 
            // gbDica
            // 
            this.gbDica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDica.Controls.Add(this.lbDica);
            this.gbDica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDica.Location = new System.Drawing.Point(12, 12);
            this.gbDica.Name = "gbDica";
            this.gbDica.Size = new System.Drawing.Size(354, 46);
            this.gbDica.TabIndex = 3;
            this.gbDica.TabStop = false;
            this.gbDica.Text = "Dica:";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Location = new System.Drawing.Point(6, 20);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(0, 21);
            this.lbDica.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbLetra);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(158, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe Uma Letra";
            // 
            // tbLetra
            // 
            this.tbLetra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLetra.Location = new System.Drawing.Point(6, 31);
            this.tbLetra.MaxLength = 1;
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.Size = new System.Drawing.Size(151, 22);
            this.tbLetra.TabIndex = 2;
            this.tbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(39, 59);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gbTentativasRestantes
            // 
            this.gbTentativasRestantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTentativasRestantes.Controls.Add(this.lbseparador);
            this.gbTentativasRestantes.Controls.Add(this.lbTentativas);
            this.gbTentativasRestantes.Controls.Add(this.lbJogadas);
            this.gbTentativasRestantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbTentativasRestantes.Location = new System.Drawing.Point(372, 12);
            this.gbTentativasRestantes.Name = "gbTentativasRestantes";
            this.gbTentativasRestantes.Size = new System.Drawing.Size(81, 46);
            this.gbTentativasRestantes.TabIndex = 2;
            this.gbTentativasRestantes.TabStop = false;
            this.gbTentativasRestantes.Text = "Jogadas";
            // 
            // lbseparador
            // 
            this.lbseparador.AutoSize = true;
            this.lbseparador.Location = new System.Drawing.Point(32, 20);
            this.lbseparador.Name = "lbseparador";
            this.lbseparador.Size = new System.Drawing.Size(16, 21);
            this.lbseparador.TabIndex = 1;
            this.lbseparador.Text = "/";
            // 
            // lbTentativas
            // 
            this.lbTentativas.AutoSize = true;
            this.lbTentativas.Location = new System.Drawing.Point(6, 20);
            this.lbTentativas.Name = "lbTentativas";
            this.lbTentativas.Size = new System.Drawing.Size(19, 21);
            this.lbTentativas.TabIndex = 0;
            this.lbTentativas.Text = "6";
            // 
            // lbJogadas
            // 
            this.lbJogadas.AutoSize = true;
            this.lbJogadas.Location = new System.Drawing.Point(58, 20);
            this.lbJogadas.Name = "lbJogadas";
            this.lbJogadas.Size = new System.Drawing.Size(19, 21);
            this.lbJogadas.TabIndex = 0;
            this.lbJogadas.Text = "0";
            this.lbJogadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPalavraSecreta
            // 
            this.TbPalavraSecreta.Enabled = false;
            this.TbPalavraSecreta.Location = new System.Drawing.Point(4, 127);
            this.TbPalavraSecreta.Name = "TbPalavraSecreta";
            this.TbPalavraSecreta.Size = new System.Drawing.Size(441, 23);
            this.TbPalavraSecreta.TabIndex = 0;
            // 
            // lbpalavraSecreta
            // 
            this.lbpalavraSecreta.AutoSize = true;
            this.lbpalavraSecreta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbpalavraSecreta.Location = new System.Drawing.Point(166, 164);
            this.lbpalavraSecreta.Name = "lbpalavraSecreta";
            this.lbpalavraSecreta.Size = new System.Drawing.Size(115, 21);
            this.lbpalavraSecreta.TabIndex = 1;
            this.lbpalavraSecreta.Text = "Palavra Secreta";
            // 
            // btnHerois
            // 
            this.btnHerois.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHerois.Location = new System.Drawing.Point(12, 302);
            this.btnHerois.Name = "btnHerois";
            this.btnHerois.Size = new System.Drawing.Size(81, 23);
            this.btnHerois.TabIndex = 1;
            this.btnHerois.Text = "Herois";
            this.btnHerois.UseVisualStyleBackColor = true;
            this.btnHerois.Click += new System.EventHandler(this.btnHerois_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimais.Location = new System.Drawing.Point(99, 302);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(81, 23);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(378, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbLetrasDigitadas
            // 
            this.tbLetrasDigitadas.Enabled = false;
            this.tbLetrasDigitadas.Location = new System.Drawing.Point(2, 61);
            this.tbLetrasDigitadas.Name = "tbLetrasDigitadas";
            this.tbLetrasDigitadas.Size = new System.Drawing.Size(441, 23);
            this.tbLetrasDigitadas.TabIndex = 4;
            // 
            // lbLetrasDigitadas
            // 
            this.lbLetrasDigitadas.AutoSize = true;
            this.lbLetrasDigitadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLetrasDigitadas.Location = new System.Drawing.Point(164, 98);
            this.lbLetrasDigitadas.Name = "lbLetrasDigitadas";
            this.lbLetrasDigitadas.Size = new System.Drawing.Size(121, 21);
            this.lbLetrasDigitadas.TabIndex = 5;
            this.lbLetrasDigitadas.Text = "Letras Digitadas";
            // 
            // FormJogoDaForca
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 337);
            this.Controls.Add(this.btnAnimais);
            this.Controls.Add(this.btnHerois);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnJogo);
            this.Name = "FormJogoDaForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Forca";
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.gbDica.ResumeLayout(false);
            this.gbDica.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTentativasRestantes.ResumeLayout(false);
            this.gbTentativasRestantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbpalavraSecreta;
        private System.Windows.Forms.TextBox TbPalavraSecreta;
        private System.Windows.Forms.GroupBox gbTentativasRestantes;
        private System.Windows.Forms.Label lbJogadas;
        private System.Windows.Forms.Label lbTentativas;
        private System.Windows.Forms.Label lbseparador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox gbDica;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Button btnHerois;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.TextBox tbLetrasDigitadas;
        private System.Windows.Forms.Label lbLetrasDigitadas;
    }
}

