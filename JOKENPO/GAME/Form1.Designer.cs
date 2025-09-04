namespace GAME
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.gpEscolhas = new System.Windows.Forms.GroupBox();
            this.rbPedra = new System.Windows.Forms.RadioButton();
            this.rbTesoura = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbLegenda = new System.Windows.Forms.Label();
            this.lbPontuacao = new System.Windows.Forms.Label();
            this.lbPonto = new System.Windows.Forms.Label();
            this.picEscolha = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.gpEscolhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscolha)).BeginInit();
            this.SuspendLayout();
            // 
            // gpEscolhas
            // 
            this.gpEscolhas.Controls.Add(this.rbPedra);
            this.gpEscolhas.Controls.Add(this.rbTesoura);
            this.gpEscolhas.Controls.Add(this.rbPapel);
            this.gpEscolhas.Controls.Add(this.rbDefault);
            this.gpEscolhas.Location = new System.Drawing.Point(89, 312);
            this.gpEscolhas.Name = "gpEscolhas";
            this.gpEscolhas.Size = new System.Drawing.Size(600, 100);
            this.gpEscolhas.TabIndex = 0;
            this.gpEscolhas.TabStop = false;
            // 
            // rbPedra
            // 
            this.rbPedra.BackColor = System.Drawing.Color.Transparent;
            this.rbPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbPedra.BackgroundImage")));
            this.rbPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPedra.Location = new System.Drawing.Point(71, 19);
            this.rbPedra.Name = "rbPedra";
            this.rbPedra.Size = new System.Drawing.Size(97, 70);
            this.rbPedra.TabIndex = 3;
            this.rbPedra.TabStop = true;
            this.rbPedra.Text = "Pedra";
            this.rbPedra.UseVisualStyleBackColor = false;
            // 
            // rbTesoura
            // 
            this.rbTesoura.BackColor = System.Drawing.Color.Transparent;
            this.rbTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbTesoura.BackgroundImage")));
            this.rbTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbTesoura.Location = new System.Drawing.Point(474, 19);
            this.rbTesoura.Name = "rbTesoura";
            this.rbTesoura.Size = new System.Drawing.Size(97, 70);
            this.rbTesoura.TabIndex = 2;
            this.rbTesoura.TabStop = true;
            this.rbTesoura.Text = "Tesoura";
            this.rbTesoura.UseVisualStyleBackColor = false;
            // 
            // rbPapel
            // 
            this.rbPapel.BackColor = System.Drawing.Color.Transparent;
            this.rbPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbPapel.BackgroundImage")));
            this.rbPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPapel.Location = new System.Drawing.Point(252, 19);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(97, 70);
            this.rbPapel.TabIndex = 1;
            this.rbPapel.TabStop = true;
            this.rbPapel.Text = "Papel";
            this.rbPapel.UseVisualStyleBackColor = false;
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(6, 77);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(59, 17);
            this.rbDefault.TabIndex = 0;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default";
            this.rbDefault.UseVisualStyleBackColor = true;
            this.rbDefault.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbLegenda
            // 
            this.lbLegenda.AutoSize = true;
            this.lbLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLegenda.Location = new System.Drawing.Point(340, 26);
            this.lbLegenda.Name = "lbLegenda";
            this.lbLegenda.Size = new System.Drawing.Size(0, 55);
            this.lbLegenda.TabIndex = 1;
            // 
            // lbPontuacao
            // 
            this.lbPontuacao.AutoSize = true;
            this.lbPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontuacao.Location = new System.Drawing.Point(13, 13);
            this.lbPontuacao.Name = "lbPontuacao";
            this.lbPontuacao.Size = new System.Drawing.Size(115, 24);
            this.lbPontuacao.TabIndex = 2;
            this.lbPontuacao.Text = "Pontuação:";
            // 
            // lbPonto
            // 
            this.lbPonto.AutoSize = true;
            this.lbPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPonto.Location = new System.Drawing.Point(124, 13);
            this.lbPonto.Name = "lbPonto";
            this.lbPonto.Size = new System.Drawing.Size(21, 24);
            this.lbPonto.TabIndex = 3;
            this.lbPonto.Text = "0";
            // 
            // picEscolha
            // 
            this.picEscolha.Location = new System.Drawing.Point(311, 106);
            this.picEscolha.Name = "picEscolha";
            this.picEscolha.Size = new System.Drawing.Size(153, 141);
            this.picEscolha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEscolha.TabIndex = 4;
            this.picEscolha.TabStop = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(153, 167);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(505, 39);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Aperte qulquer tecla para iniciar";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picEscolha);
            this.Controls.Add(this.lbPonto);
            this.Controls.Add(this.lbPontuacao);
            this.Controls.Add(this.lbLegenda);
            this.Controls.Add(this.gpEscolhas);
            this.Name = "frmGame";
            this.Text = "JOKENPO";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGame_KeyPress);
            this.gpEscolhas.ResumeLayout(false);
            this.gpEscolhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscolha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEscolhas;
        private System.Windows.Forms.RadioButton rbTesoura;
        private System.Windows.Forms.RadioButton rbPapel;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbLegenda;
        private System.Windows.Forms.RadioButton rbPedra;
        private System.Windows.Forms.Label lbPontuacao;
        private System.Windows.Forms.Label lbPonto;
        private System.Windows.Forms.PictureBox picEscolha;
        private System.Windows.Forms.Label lblStart;
    }
}

