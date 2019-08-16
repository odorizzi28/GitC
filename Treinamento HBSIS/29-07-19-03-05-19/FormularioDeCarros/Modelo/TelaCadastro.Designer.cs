namespace FormularioDeCarros.Modelo
{
    partial class TelaCadastro
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
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.Placa = new System.Windows.Forms.Label();
            this.TbxAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(95, 127);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(237, 22);
            this.tbxPlaca.TabIndex = 11;
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Location = new System.Drawing.Point(28, 127);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(43, 17);
            this.Placa.TabIndex = 10;
            this.Placa.Text = "Placa";
            // 
            // TbxAno
            // 
            this.TbxAno.Location = new System.Drawing.Point(95, 73);
            this.TbxAno.Name = "TbxAno";
            this.TbxAno.Size = new System.Drawing.Size(237, 22);
            this.TbxAno.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ano";
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(95, 23);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(237, 22);
            this.tbxModelo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.TbxAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.TextBox TbxAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}