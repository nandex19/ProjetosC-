namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tPeso = new System.Windows.Forms.TextBox();
            this.tValor = new System.Windows.Forms.TextBox();
            this.tAltura = new System.Windows.Forms.TextBox();
            this.tNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Button();
            this.Largura = new System.Windows.Forms.Label();
            this.tLargura = new System.Windows.Forms.TextBox();
            this.Comprimento = new System.Windows.Forms.Label();
            this.tComprimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            // 
            // tPeso
            // 
            this.tPeso.Location = new System.Drawing.Point(75, 62);
            this.tPeso.Name = "tPeso";
            this.tPeso.Size = new System.Drawing.Size(100, 22);
            this.tPeso.TabIndex = 1;
            // 
            // tValor
            // 
            this.tValor.Location = new System.Drawing.Point(75, 118);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(100, 22);
            this.tValor.TabIndex = 2;
            // 
            // tAltura
            // 
            this.tAltura.Location = new System.Drawing.Point(75, 90);
            this.tAltura.Name = "tAltura";
            this.tAltura.Size = new System.Drawing.Size(100, 22);
            this.tAltura.TabIndex = 3;
            // 
            // tNome
            // 
            this.tNome.Location = new System.Drawing.Point(75, 34);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(100, 22);
            this.tNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 34);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Location = new System.Drawing.Point(12, 65);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(40, 17);
            this.Peso.TabIndex = 7;
            this.Peso.Text = "Peso";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(12, 93);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(45, 17);
            this.Altura.TabIndex = 8;
            this.Altura.Text = "Altura";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(12, 118);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(41, 17);
            this.Valor.TabIndex = 9;
            this.Valor.Text = "Valor";
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(453, 297);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(245, 83);
            this.bt.TabIndex = 10;
            this.bt.Text = "Submeter";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // Largura
            // 
            this.Largura.AutoSize = true;
            this.Largura.Location = new System.Drawing.Point(225, 96);
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(58, 17);
            this.Largura.TabIndex = 12;
            this.Largura.Text = "Largura";
            // 
            // tLargura
            // 
            this.tLargura.Location = new System.Drawing.Point(288, 93);
            this.tLargura.Name = "tLargura";
            this.tLargura.Size = new System.Drawing.Size(100, 22);
            this.tLargura.TabIndex = 11;
            // 
            // Comprimento
            // 
            this.Comprimento.AutoSize = true;
            this.Comprimento.Location = new System.Drawing.Point(451, 96);
            this.Comprimento.Name = "Comprimento";
            this.Comprimento.Size = new System.Drawing.Size(91, 17);
            this.Comprimento.TabIndex = 14;
            this.Comprimento.Text = "Comprimento";
            // 
            // tComprimento
            // 
            this.tComprimento.Location = new System.Drawing.Point(566, 93);
            this.tComprimento.Name = "tComprimento";
            this.tComprimento.Size = new System.Drawing.Size(100, 22);
            this.tComprimento.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 392);
            this.Controls.Add(this.Comprimento);
            this.Controls.Add(this.tComprimento);
            this.Controls.Add(this.Largura);
            this.Controls.Add(this.tLargura);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.tAltura);
            this.Controls.Add(this.tValor);
            this.Controls.Add(this.tPeso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPeso;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.TextBox tAltura;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label Largura;
        private System.Windows.Forms.TextBox tLargura;
        private System.Windows.Forms.Label Comprimento;
        private System.Windows.Forms.TextBox tComprimento;
    }
}

