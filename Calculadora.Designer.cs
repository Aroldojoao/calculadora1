
namespace Calculadora
{
    partial class Calculadora
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
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnSubtracao = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnDivisao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.calculos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNLIMPAR = new System.Windows.Forms.Button();
            this.Btnsair = new System.Windows.Forms.Button();
            this.btnperc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSoma
            // 
            this.BtnSoma.BackColor = System.Drawing.Color.Lime;
            this.BtnSoma.FlatAppearance.BorderSize = 0;
            this.BtnSoma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.BtnSoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.Location = new System.Drawing.Point(315, 156);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(91, 50);
            this.BtnSoma.TabIndex = 3;
            this.BtnSoma.Text = "+";
            this.BtnSoma.UseVisualStyleBackColor = false;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSOMA_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.BackColor = System.Drawing.Color.Lime;
            this.BtnSubtracao.FlatAppearance.BorderSize = 0;
            this.BtnSubtracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.BtnSubtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtracao.Location = new System.Drawing.Point(420, 156);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.Size = new System.Drawing.Size(91, 50);
            this.BtnSubtracao.TabIndex = 4;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.UseVisualStyleBackColor = false;
            this.BtnSubtracao.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.BackColor = System.Drawing.Color.Lime;
            this.BtnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.BtnMultiplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.BtnMultiplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.Location = new System.Drawing.Point(315, 211);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(91, 50);
            this.BtnMultiplicacao.TabIndex = 5;
            this.BtnMultiplicacao.Text = "*";
            this.BtnMultiplicacao.UseVisualStyleBackColor = false;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // BtnDivisao
            // 
            this.BtnDivisao.BackColor = System.Drawing.Color.Lime;
            this.BtnDivisao.FlatAppearance.BorderSize = 0;
            this.BtnDivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.BtnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisao.Location = new System.Drawing.Point(420, 211);
            this.BtnDivisao.Name = "BtnDivisao";
            this.BtnDivisao.Size = new System.Drawing.Size(91, 50);
            this.BtnDivisao.TabIndex = 6;
            this.BtnDivisao.Text = "/";
            this.BtnDivisao.UseVisualStyleBackColor = false;
            this.BtnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(363, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(363, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 26);
            this.textBox2.TabIndex = 11;
            // 
            // txtResultado
            // 
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(363, 329);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(143, 26);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TabStop = false;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // calculos
            // 
            this.calculos.AutoSize = true;
            this.calculos.BackColor = System.Drawing.Color.Transparent;
            this.calculos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculos.Location = new System.Drawing.Point(276, 35);
            this.calculos.Name = "calculos";
            this.calculos.Size = new System.Drawing.Size(208, 22);
            this.calculos.TabIndex = 7;
            this.calculos.Text = "CÁLCULOS BÁSICOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "DIGITE O 1º NÚMERO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "DIGITE O 2º NÚMERO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "RESULTADO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BTNLIMPAR
            // 
            this.BTNLIMPAR.BackColor = System.Drawing.Color.Lime;
            this.BTNLIMPAR.FlatAppearance.BorderSize = 0;
            this.BTNLIMPAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.BTNLIMPAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLIMPAR.Location = new System.Drawing.Point(574, 156);
            this.BTNLIMPAR.Name = "BTNLIMPAR";
            this.BTNLIMPAR.Size = new System.Drawing.Size(96, 50);
            this.BTNLIMPAR.TabIndex = 8;
            this.BTNLIMPAR.Text = "LIMPAR";
            this.BTNLIMPAR.UseVisualStyleBackColor = false;
            this.BTNLIMPAR.Click += new System.EventHandler(this.BTNLIMPAR_Click);
            // 
            // Btnsair
            // 
            this.Btnsair.BackColor = System.Drawing.Color.Lime;
            this.Btnsair.FlatAppearance.BorderSize = 0;
            this.Btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.Btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsair.Location = new System.Drawing.Point(574, 211);
            this.Btnsair.Name = "Btnsair";
            this.Btnsair.Size = new System.Drawing.Size(96, 50);
            this.Btnsair.TabIndex = 9;
            this.Btnsair.Text = "SAIR";
            this.Btnsair.UseVisualStyleBackColor = false;
            this.Btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // btnperc
            // 
            this.btnperc.BackColor = System.Drawing.Color.Lime;
            this.btnperc.FlatAppearance.BorderSize = 0;
            this.btnperc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnperc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnperc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnperc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperc.Location = new System.Drawing.Point(315, 267);
            this.btnperc.Name = "btnperc";
            this.btnperc.Size = new System.Drawing.Size(91, 50);
            this.btnperc.TabIndex = 7;
            this.btnperc.Text = "%";
            this.btnperc.UseVisualStyleBackColor = false;
            this.btnperc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnperc);
            this.Controls.Add(this.Btnsair);
            this.Controls.Add(this.BTNLIMPAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculos);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDivisao);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnSoma);
            this.Name = "Calculadora";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnSubtracao;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnDivisao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label calculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNLIMPAR;
        private System.Windows.Forms.Button Btnsair;
        private System.Windows.Forms.Button btnperc;
    }
}

