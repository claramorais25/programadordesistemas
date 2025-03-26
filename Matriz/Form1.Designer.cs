
namespace Matriz
{
    partial class frmMatriz
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
            this.lblExibirMariz = new System.Windows.Forms.Label();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExibirMaior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExibirMariz
            // 
            this.lblExibirMariz.AutoSize = true;
            this.lblExibirMariz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirMariz.Location = new System.Drawing.Point(12, 52);
            this.lblExibirMariz.Name = "lblExibirMariz";
            this.lblExibirMariz.Size = new System.Drawing.Size(191, 16);
            this.lblExibirMariz.TabIndex = 0;
            this.lblExibirMariz.Text = "Entre com os valores da matriz";
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(209, 52);
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(84, 20);
            this.txtMatriz.TabIndex = 1;
            this.txtMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriz_KeyPress_1);
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.Location = new System.Drawing.Point(113, 101);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(115, 39);
            this.btnMostrarMatriz.TabIndex = 2;
            this.btnMostrarMatriz.Text = "Mostrar Matriz";
            this.btnMostrarMatriz.UseVisualStyleBackColor = true;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 95);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnExibirMaior
            // 
            this.btnExibirMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirMaior.Location = new System.Drawing.Point(99, 290);
            this.btnExibirMaior.Name = "btnExibirMaior";
            this.btnExibirMaior.Size = new System.Drawing.Size(129, 66);
            this.btnExibirMaior.TabIndex = 4;
            this.btnExibirMaior.Text = "Exibir Maior Valor";
            this.btnExibirMaior.UseVisualStyleBackColor = true;
            this.btnExibirMaior.Click += new System.EventHandler(this.btnExibirMaior_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 456);
            this.Controls.Add(this.btnExibirMaior);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.lblExibirMariz);
            this.Name = "frmMatriz";
            this.Text = "Matriz 3x3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibirMariz;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExibirMaior;
    }
}

