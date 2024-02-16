namespace Soma2Numeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnSomar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.TxtNumero3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.BackColor = System.Drawing.Color.Lime;
            this.TxtNumero1.Location = new System.Drawing.Point(191, 22);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 56);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(175, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Digite o 2° Número Inteiro:";
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.BackColor = System.Drawing.Color.Lime;
            this.TxtNumero2.Location = new System.Drawing.Point(191, 56);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero2.TabIndex = 3;
            // 
            // BtnSomar
            // 
            this.BtnSomar.BackColor = System.Drawing.Color.Lime;
            this.BtnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSomar.Location = new System.Drawing.Point(76, 128);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(122, 36);
            this.BtnSomar.TabIndex = 4;
            this.BtnSomar.Text = "Calcular a Soma";
            this.BtnSomar.UseVisualStyleBackColor = false;
            this.BtnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Lime;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(265, 176);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(23, 25);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "0";
            this.LblTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(10, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(175, 17);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Digite o 1° Número Inteiro:";
            this.lbl1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(10, 88);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(175, 17);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Digite o 3° Número Inteiro:";
            // 
            // TxtNumero3
            // 
            this.TxtNumero3.BackColor = System.Drawing.Color.Lime;
            this.TxtNumero3.Location = new System.Drawing.Point(191, 88);
            this.TxtNumero3.Name = "TxtNumero3";
            this.TxtNumero3.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "A soma de todos os Números Inteiros foram:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(303, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumero3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnSomar);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox TxtNumero3;
        private System.Windows.Forms.Label label2;
    }
}

