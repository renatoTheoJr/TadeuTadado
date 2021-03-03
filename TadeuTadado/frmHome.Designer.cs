namespace TadeuTadado
{
    partial class frmHome
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(176, 381);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(272, 78);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(176, 239);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(272, 78);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 534);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCadastro;
    }
}