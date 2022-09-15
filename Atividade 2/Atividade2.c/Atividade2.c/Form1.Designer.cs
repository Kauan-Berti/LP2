namespace Atividade2.c
{
    partial class Form1
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
            this.lvlNum1 = new System.Windows.Forms.Label();
            this.lvlNum2 = new System.Windows.Forms.Label();
            this.lvlResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvlNum1
            // 
            this.lvlNum1.AutoSize = true;
            this.lvlNum1.Location = new System.Drawing.Point(149, 61);
            this.lvlNum1.Name = "lvlNum1";
            this.lvlNum1.Size = new System.Drawing.Size(53, 13);
            this.lvlNum1.TabIndex = 0;
            this.lvlNum1.Text = "Numero 1";
            // 
            // lvlNum2
            // 
            this.lvlNum2.AutoSize = true;
            this.lvlNum2.Location = new System.Drawing.Point(149, 100);
            this.lvlNum2.Name = "lvlNum2";
            this.lvlNum2.Size = new System.Drawing.Size(53, 13);
            this.lvlNum2.TabIndex = 1;
            this.lvlNum2.Text = "Numero 2";
            // 
            // lvlResultado
            // 
            this.lvlResultado.AutoSize = true;
            this.lvlResultado.Location = new System.Drawing.Point(149, 136);
            this.lvlResultado.Name = "lvlResultado";
            this.lvlResultado.Size = new System.Drawing.Size(55, 13);
            this.lvlResultado.TabIndex = 2;
            this.lvlResultado.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(524, 50);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(524, 100);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(152, 194);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 5;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(275, 194);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 6;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(398, 194);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(75, 23);
            this.btnmult.TabIndex = 7;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(524, 194);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(240, 58);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(233, 20);
            this.txtnumero1.TabIndex = 9;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(240, 97);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(233, 20);
            this.txtnumero2.TabIndex = 10;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(240, 133);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(233, 20);
            this.txtresultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 462);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lvlResultado);
            this.Controls.Add(this.lvlNum2);
            this.Controls.Add(this.lvlNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlNum1;
        private System.Windows.Forms.Label lvlNum2;
        private System.Windows.Forms.Label lvlResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

