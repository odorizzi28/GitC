namespace MVCProject.View.Edicao
{
    partial class frmEdicaoUsuarios
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
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(105, 118);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(245, 22);
            this.txbEmail.TabIndex = 47;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(22, 164);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(328, 69);
            this.BtSalvar.TabIndex = 46;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(105, 87);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(245, 22);
            this.tbxSenha.TabIndex = 45;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(105, 52);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(245, 22);
            this.tbxLogin.TabIndex = 44;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(105, 18);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(245, 22);
            this.tbxNome.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome:";
            // 
            // frmEdicaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 270);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEdicaoUsuarios";
            this.Text = "frmEdicaoUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}