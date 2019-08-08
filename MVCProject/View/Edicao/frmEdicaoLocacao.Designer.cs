namespace MVCProject.View.Edicao
{
    partial class frmEdicaoLocacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLivro = new System.Windows.Forms.ComboBox();
            this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Devolução:";
            // 
            // comboLivro
            // 
            this.comboLivro.FormattingEnabled = true;
            this.comboLivro.Location = new System.Drawing.Point(102, 9);
            this.comboLivro.Name = "comboLivro";
            this.comboLivro.Size = new System.Drawing.Size(198, 24);
            this.comboLivro.TabIndex = 3;
            // 
            // dateDevolucao
            // 
            this.dateDevolucao.Location = new System.Drawing.Point(100, 82);
            this.dateDevolucao.Name = "dateDevolucao";
            this.dateDevolucao.Size = new System.Drawing.Size(200, 22);
            this.dateDevolucao.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(102, 44);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(198, 22);
            this.tbxTipo.TabIndex = 7;
            // 
            // frmEdicaoLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 241);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateDevolucao);
            this.Controls.Add(this.comboLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEdicaoLocacao";
            this.Text = "frmEdicaoLocacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLivro;
        private System.Windows.Forms.DateTimePicker dateDevolucao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxTipo;
    }
}