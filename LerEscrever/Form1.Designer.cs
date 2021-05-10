
namespace LerEscrever
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
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLerTxt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLerBinario = new System.Windows.Forms.Button();
            this.btnEscreverBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(12, 299);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(152, 49);
            this.btnEscrever.TabIndex = 1;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // btnLerTxt
            // 
            this.btnLerTxt.Location = new System.Drawing.Point(170, 299);
            this.btnLerTxt.Name = "btnLerTxt";
            this.btnLerTxt.Size = new System.Drawing.Size(152, 49);
            this.btnLerTxt.TabIndex = 2;
            this.btnLerTxt.Text = "Ler Txt";
            this.btnLerTxt.UseVisualStyleBackColor = true;
            this.btnLerTxt.Click += new System.EventHandler(this.btnLerTxt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 258);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // btnLerBinario
            // 
            this.btnLerBinario.Location = new System.Drawing.Point(328, 299);
            this.btnLerBinario.Name = "btnLerBinario";
            this.btnLerBinario.Size = new System.Drawing.Size(152, 49);
            this.btnLerBinario.TabIndex = 4;
            this.btnLerBinario.Text = "Ler Binario";
            this.btnLerBinario.UseVisualStyleBackColor = true;
            this.btnLerBinario.Click += new System.EventHandler(this.btnLerBinario_Click);
            // 
            // btnEscreverBinario
            // 
            this.btnEscreverBinario.Location = new System.Drawing.Point(486, 299);
            this.btnEscreverBinario.Name = "btnEscreverBinario";
            this.btnEscreverBinario.Size = new System.Drawing.Size(152, 49);
            this.btnEscreverBinario.TabIndex = 5;
            this.btnEscreverBinario.Text = "Escrever Binario";
            this.btnEscreverBinario.UseVisualStyleBackColor = true;
            this.btnEscreverBinario.Click += new System.EventHandler(this.btnEscreverBinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 387);
            this.Controls.Add(this.btnEscreverBinario);
            this.Controls.Add(this.btnLerBinario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLerTxt);
            this.Controls.Add(this.btnEscrever);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLerTxt;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Button btnLerBinario;
        private System.Windows.Forms.Button btnEscreverBinario;
    }
}

